﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OpereDarteConservateNeiMuseiInLombardia
{
    public partial class Form1 : Form
    {
        Catalogo catalogo;
        private bool isFullScreen = false;  // Variabile di stato per tenere traccia della modalità schermo intero
        private FormBorderStyle prevFormBorderStyle;
        private FormWindowState prevWindowState;
        private Rectangle prevBounds;
        public Form1()
        {
            InitializeComponent();
            catalogo = new Catalogo(this);
            this.KeyPreview = true;
            riempiListaPerFiltro();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            catalogo.LeggiFile();
            grigliaOpere.DataSource = catalogo.opere;
            //grigliaOpere.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //grigliaOpere.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grigliaOpere.ReadOnly = true;
            gmap.Visible = false;
            webBrowser.Visible = false;
            pnl_listBox.Visible = false;
            InitializeMap();
            riempiCombo();
            ContaOpere();
        }

        private void grigliaOpere_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ricerche_Click(object sender, EventArgs e)
        {
            pnl_listBox.Visible = false;
        }

        private void btn_filtroDinamico_Click(object sender, EventArgs e)
        {
            pnl_listBox.Visible = true;
        }

        private void btn_cercaOperaPerID_Click(object sender, EventArgs e)
        {
            int risultato = catalogo.CercaOperaPerID((List<Opera>)grigliaOpere.DataSource);
            if (risultato != -1)
            {
                //MessageBox.Show("Opera trovata all'indice: " + risultato);
                grigliaOpere.ClearSelection();
                grigliaOpere.Rows[risultato].Selected = true;
                grigliaOpere.FirstDisplayedScrollingRowIndex = risultato;
                MostraGriglia();
            }
            else
            {
                MessageBox.Show("Opera non trovata.");
            }
        }
        private void btn_CercaOperaPerDescrizione_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.CercaOperaPerDescrizione((List<Opera>)grigliaOpere.DataSource);
            MostraGriglia();
            ContaOpere();
        }

        private void btn_cercaOperaPerSoggetto_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.CercaOperaPerSoggetto((List<Opera>)grigliaOpere.DataSource);
            MostraGriglia();
            ContaOpere();
        }

        private void btn_cercaImmagine_Click(object sender, EventArgs e)
        {
            int risultato = catalogo.CercaImmagine((List<Opera>)grigliaOpere.DataSource);
            if (risultato != -1)
            {
                string url = ((List<Opera>)grigliaOpere.DataSource)[risultato].Url;
                webBrowser.Navigate(url);
                webBrowser.Visible = true;
                gmap.Visible = false;
                grigliaOpere.Visible = false;
            }
            else
            {
                MessageBox.Show("Opera non trovata.");
            }
        }

        private void grigliaOpere_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C) // Se è premuto Ctrl + C
            {
                if (grigliaOpere.CurrentCell != null) // Controlla se c'è una cella selezionata
                {
                    // Ottieni il valore della cella corrente
                    string value = grigliaOpere.CurrentCell.Value?.ToString();

                    // Copia il valore della cella negli appunti
                    if (value != null)
                    {
                        Clipboard.SetText(value);
                    }
                }
            }
        }

        private void btn_caricaCatalogo_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.opere;
            gmap.Visible = false;
            webBrowser.Visible = false;
            grigliaOpere.Visible = true;
            ContaOpere();

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F)
            {
                ToggleFullScreen();
            }
        }

        private void ToggleFullScreen()
        {
            if (isFullScreen)
            {
                // Ripristina la finestra alle impostazioni precedenti
                this.FormBorderStyle = prevFormBorderStyle;
                this.WindowState = prevWindowState;
                this.Bounds = prevBounds;
                isFullScreen = false;
            }
            else
            {
                // Salva le impostazioni attuali della finestra
                prevFormBorderStyle = this.FormBorderStyle;
                prevWindowState = this.WindowState;
                prevBounds = this.Bounds;

                // Imposta la finestra in modalità schermo intero
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Normal;  // Imposta lo stato a normale per poter modificare le dimensioni
                this.Bounds = Screen.PrimaryScreen.Bounds;  // Imposta la form a coprire l'intero schermo
                this.TopMost = true;  // Porta la finestra in primo piano
                isFullScreen = true;
            }
        }

        private void InitializeMap()
        {
            // Imposta il provider della mappa
            gmap.MapProvider = GMapProviders.GoogleMap;

            // Imposta le coordinate iniziali della mappa
            gmap.Position = new PointLatLng(45.4654219, 9.1859243); // Milano

            // Imposta zoom
            gmap.MinZoom = 2;
            gmap.MaxZoom = 20;
            gmap.Zoom = 10;

            // Abilita lo zoom tramite mouse
            gmap.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;

            // Abilita i controlli della mappa
            gmap.CanDragMap = true;
            gmap.DragButton = MouseButtons.Left;

            // Imposta modalità di rendering (vero o falso)
            gmap.ShowCenter = false;


            var markersOverlay = new GMapOverlay("markers");
            // Aggiungi dei marker sulla mappa
            HashSet<string> locationUniche = new HashSet<string>();
            List<Opera> catalogoSenzaDuplicati = new List<Opera>();

            foreach (var opera in catalogo.opere)
            {
                if (locationUniche.Add(opera.Location))
                {
                    catalogoSenzaDuplicati.Add(opera);
                }
            }

            for (int i = 0; i < catalogoSenzaDuplicati.Count; i++)
            {
                var marker = new GMarkerGoogle(ConvertiCoordinate(catalogoSenzaDuplicati[i].Location), GMarkerGoogleType.red_dot);
                if (marker.Position.Lat != 0 && marker.Position.Lng != 0)
                {
                    markersOverlay.Markers.Add(marker);
                }
            }
            gmap.Overlays.Add(markersOverlay);

            gmap.Refresh();

        }

        public PointLatLng ConvertiCoordinate(string coordinate)
        {
            coordinate = coordinate.Trim('(', ')').Trim();
            string[] campi = coordinate.Split(',');
            if (campi.Length != 2)
            {
                return new PointLatLng(0, 0);
            }
            // Variabili per latitudine e longitudine
            double latitude, longitude;


            // Prova a convertire le parti in double
            if (!double.TryParse(campi[0].Trim().Replace('.', ','), out latitude) || !double.TryParse(campi[1].Trim().Replace('.', ','), out longitude))
            {
                return new PointLatLng(0, 0);  // Valore predefinito
            }

            // Crea e restituisci un nuovo oggetto PointLatLng
            return new PointLatLng(latitude, longitude);
        }

        private void btn_mappa_Click(object sender, EventArgs e)
        {

            if (gmap.Visible)
            {
                gmap.Visible = false;
                webBrowser.Visible = false;
                grigliaOpere.Visible = true;
            }
            else
            {
                gmap.Visible = true;
                webBrowser.Visible = false;
                grigliaOpere.Visible = false;
            }
        }

        public void MostraGriglia()
        {
            if (gmap.Visible == true || webBrowser.Visible == true)
            {
                gmap.Visible = false;
                webBrowser.Visible = false;
                grigliaOpere.Visible = true;
            }
        }

        private void btn_cercaMuseo_Click(object sender, EventArgs e)
        {
            int risultato = catalogo.CercaMuseo((List<Opera>)grigliaOpere.DataSource);
            if (risultato != -1)
            {
                //MessageBox.Show("Opera trovata all'indice: " + risultato);
                gmap.Position = ConvertiCoordinate(((List<Opera>)grigliaOpere.DataSource)[risultato].Location);
                gmap.Zoom = 18;
                gmap.Visible = true;
                grigliaOpere.Visible = false;
                webBrowser.Visible = false;
            }
            else
            {
                MessageBox.Show("Museo non trovato.");
            }
        }

        private void btn_cercaEventi_Click(object sender, EventArgs e)
        {
            webBrowser.ScriptErrorsSuppressed = true;

            webBrowser.Navigate("https://www.musei.regione.lombardia.it/wps/portal/site/musei-riconosciuti-in-lombardia/eventi-e-novita");
            webBrowser.Visible = true;
            grigliaOpere.Visible = false;
            gmap.Visible = false;
        }

        private void btn_mostraBrowser_Click(object sender, EventArgs e)
        {
            if (webBrowser.Visible)
            {
                gmap.Visible = false;
                webBrowser.Visible = false;
                grigliaOpere.Visible = true;
            }
            else
            {
                gmap.Visible = false;
                webBrowser.Visible = true;
                grigliaOpere.Visible = false;
            }
        }

        public string GetSignificato(string sigla)
        {
            switch (sigla)
            {
                case "Idk":
                    return "Identificativo unico dell'opera";
                case "Esc":
                    return "Ente o museo che ospita l'opera";
                case "Grp":
                    return "Gruppo di opere d'arte (categoria)";
                case "Ogtd":
                    return "Tipo di opera (es. dipinto, scultura)";
                case "Sgti":
                    return "Soggetto dell'opera";
                case "Pvcp":
                    return "Sigla provincia";
                case "Pvcn":
                    return "Provincia di origine";
                case "Pvcc":
                    return "Comune di origine";
                case "Ldct":
                    return "Tipo di edificio dove si trova l'opera";
                case "Ldcq":
                    return "Tipo di ente";
                case "Ldcn":
                    return "Nome dell'edificio";
                case "Ldcu":
                    return "Indirizzo dell'edificio";
                case "Ldcm":
                    return "Nome del museo o dell'ente che ospita l'opera";
                case "Cold":
                    return "Collezione dell'opera";
                case "Dtzg":
                    return "Datazione dell'opera (secolo)";
                case "Dtsi":
                    return "Anno di creazione dell'opera";
                case "Autn":
                    return "Nome dell'autore dell'opera";
                case "Atbd":
                    return "Categoria";
                case "Mtc":
                    return "Materiale utilizzato per l'opera";
                case "Deso":
                    return "Descrizione dell'opera";
                case "Nsc":
                    return "Note sullo stato di conservazione";
                case "Stcc":
                    return "Stato di conservazione";
                case "Cdgg":
                    return "Proprietà dell'opera";
                case "Fur":
                    return "Nome del fornitore";
                case "GpdpX":
                    return "Coordinate X della posizione";
                case "GpdpY":
                    return "Coordinate Y della posizione";
                case "Location":
                    return "Coordinate geografiche (latitudine, longitudine)";
                default:
                    return "Significato sconosciuto";
            }
        }

        private void grigliaOpere_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Recupera la sigla dall'intestazione della colonna
            string sigla = grigliaOpere.Columns[e.ColumnIndex].HeaderText;
            // Imposta il significato in base alla sigla
            string significato = GetSignificato(sigla);

            MessageBox.Show(significato);
        }

        public void riempiListaPerFiltro()
        {
            // Riempimento della CheckedListBox con gli attributi della classe Opera
            listaFiltroDin.Items.Add("Grp:Gruppo di opere d'arte");
            listaFiltroDin.Items.Add("Ogtd:Tipo di opera");
            listaFiltroDin.Items.Add("Pvcp:Sigla provincia");
            listaFiltroDin.Items.Add("Pvcn:Provincia di origine");
            listaFiltroDin.Items.Add("Pvcc:comune di origine");
            listaFiltroDin.Items.Add("Ldct:Tipo di edificio dove si trova l'opera");
            listaFiltroDin.Items.Add("Ldcq:Tipo di ente o ente pubblico");
            listaFiltroDin.Items.Add("Ldcn:Nome dell'edificio");
            listaFiltroDin.Items.Add("Ldcu:Indirizzo dell'edificio");
            listaFiltroDin.Items.Add("Ldcm:Nome del museo o dell'ente che ospita l'opera");
            listaFiltroDin.Items.Add("Cold:Collezione dell'opera");
            listaFiltroDin.Items.Add("Dtzg:Datazione dell'opera (secolo)");
            listaFiltroDin.Items.Add("Dtsi:Anno di creazione dell'opera");
            listaFiltroDin.Items.Add("Autn:Nome dell'autore dell'opera");
            listaFiltroDin.Items.Add("Atbd:Categoria");
            listaFiltroDin.Items.Add("Mtc:Materiale utilizzato per l'opera");
            listaFiltroDin.Items.Add("Stcc:Stato di conservazione");
            listaFiltroDin.Items.Add("Cdgg:Proprietà dell'opera");
            listaFiltroDin.Items.Add("Fur:Nome del fornitore");

        }

        private void btn_applicaFiltri_Click(object sender, EventArgs e)
        {
            List<string> values = new List<string>();
            List<string> checkedItems = new List<string>();
            foreach (var item in listaFiltroDin.CheckedItems)
            {
                string attributo = item.ToString().Split(':')[1];
                string input = ShowInputBox($"Inserisci {attributo}", $"Inserimento {attributo}", "");
                values.Add(input);
                checkedItems.Add(item.ToString().Split(':')[0]);
            }
            grigliaOpere.DataSource = catalogo.FiltroDinamico(values, checkedItems, (List<Opera>)grigliaOpere.DataSource);
            MostraGriglia();
            ContaOpere();
        }
        public string ShowInputBox(string prompt, string title = "Input", string defaultValue = "")
        {
            // Disabilita temporaneamente TopMost
            bool wasTopMost = this.TopMost;
            this.TopMost = false;

            // Mostra l'InputBox e raccoglie l'input dell'utente
            string result = Interaction.InputBox(prompt, title, defaultValue);

            // Ripristina TopMost allo stato precedente
            this.TopMost = wasTopMost;

            return result;
        }

        public void riempiCombo()
        {
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // Aggiungi le sigle con la descrizione
            comboBox.Items.Add("Idk: Identificativo unico dell'opera");
            comboBox.Items.Add("Esc: Ente o museo che ospita l'opera");
            comboBox.Items.Add("Grp: Gruppo di opere d'arte");
            comboBox.Items.Add("Ogtd: Tipo di opera");
            comboBox.Items.Add("Sgti: Soggetto dell'opera");
            comboBox.Items.Add("Pvcp: Sigla provincia");
            comboBox.Items.Add("Pvcn: Provincia di origine");
            comboBox.Items.Add("Pvcc: Comune di origine");
            comboBox.Items.Add("Ldct: Tipo di edificio dove si trova l'opera");
            comboBox.Items.Add("Ldcq: Tipo di ente o ente pubblico");
            comboBox.Items.Add("Ldcn: Nome dell'edificio");
            comboBox.Items.Add("Ldcu: Indirizzo dell'edificio");
            comboBox.Items.Add("Ldcm: Nome del museo o dell'ente che ospita l'opera");
            comboBox.Items.Add("Cold: Condizioni di conservazione dell'opera");
            comboBox.Items.Add("Dtsi: Anno di creazione dell'opera");
            comboBox.Items.Add("Autn: Nome dell'autore dell'opera");
            comboBox.Items.Add("Atbd: Categoria");
            comboBox.Items.Add("Mtc: Materiale utilizzato per l'opera");
            comboBox.Items.Add("Stcc: Stato di conservazione");
            comboBox.Items.Add("Cdgg: Proprietà dell'opera");
            comboBox.Items.Add("Fur: Nome del fornitore");

            comboBox.SelectedIndex = 0;
        }

        private void btn_crescente_Click(object sender, EventArgs e)
        {
            string selectedSigla = comboBox.SelectedItem.ToString().Split(':')[0].Trim();
            if (isSiglaValida(selectedSigla))
            {
                grigliaOpere.DataSource = Crescente((List<Opera>)grigliaOpere.DataSource, selectedSigla);
            }
            else
            {
                MessageBox.Show("Selezionare una sigla corretta");
            }
        }

        private List<Opera> Crescente(List<Opera> dataSource, string selectedSigla)
        {
            List<Opera> sortedList = null;

            switch (selectedSigla)
            {
                case "Idk":
                    sortedList = dataSource.OrderBy(opera => opera.Idk).ToList();
                    break;
                case "Esc":
                    sortedList = dataSource.OrderBy(opera => opera.Esc).ToList();
                    break;
                case "Grp":
                    sortedList = dataSource.OrderBy(opera => opera.Grp).ToList();
                    break;
                case "Ogtd":
                    sortedList = dataSource.OrderBy(opera => opera.Ogtd).ToList();
                    break;
                case "Sgti":
                    sortedList = dataSource.OrderBy(opera => opera.Sgti).ToList();
                    break;
                case "Pvcp":
                    sortedList = dataSource.OrderBy(opera => opera.Pvcp).ToList();
                    break;
                case "Pvcn":
                    sortedList = dataSource.OrderBy(opera => opera.Pvcn).ToList();
                    break;
                case "Pvcc":
                    sortedList = dataSource.OrderBy(opera => opera.Pvcc).ToList();
                    break;
                case "Ldct":
                    sortedList = dataSource.OrderBy(opera => opera.Ldct).ToList();
                    break;
                case "Ldcq":
                    sortedList = dataSource.OrderBy(opera => opera.Ldcq).ToList();
                    break;
                case "Ldcn":
                    sortedList = dataSource.OrderBy(opera => opera.Ldcn).ToList();
                    break;
                case "Ldcu":
                    sortedList = dataSource.OrderBy(opera => opera.Ldcu).ToList();
                    break;
                case "Ldcm":
                    sortedList = dataSource.OrderBy(opera => opera.Ldcm).ToList();
                    break;
                case "Cold":
                    sortedList = dataSource.OrderBy(opera => opera.Cold).ToList();
                    break;
                case "Dtsi":
                    sortedList = dataSource.OrderBy(opera => opera.Dtsi).ToList();
                    break;
                case "Autn":
                    sortedList = dataSource.OrderBy(opera => opera.Autn).ToList();
                    break;
                case "Atbd":
                    sortedList = dataSource.OrderBy(opera => opera.Atbd).ToList();
                    break;
                case "Mtc":
                    sortedList = dataSource.OrderBy(opera => opera.Mtc).ToList();
                    break;
                case "Stcc":
                    sortedList = dataSource.OrderBy(opera => opera.Stcc).ToList();
                    break;
                case "Cdgg":
                    sortedList = dataSource.OrderBy(opera => opera.Cdgg).ToList();
                    break;
                case "Fur":
                    sortedList = dataSource.OrderBy(opera => opera.Fur).ToList();
                    break;
                default:
                    break;
            }
            return sortedList;
        }

        private void btn_decrescente_Click(object sender, EventArgs e)
        {
            string selectedSigla = comboBox.SelectedItem.ToString().Split(':')[0].Trim();
            if (isSiglaValida(selectedSigla))
            {
                grigliaOpere.DataSource = Decrescente((List<Opera>)grigliaOpere.DataSource, selectedSigla);
            }
            else
            {
                MessageBox.Show("Selezionare una sigla corretta");
            }
        }

        private List<Opera> Decrescente(List<Opera> dataSource, string selectedSigla)
        {
            List<Opera> sortedList = null;

            switch (selectedSigla)
            {
                case "Idk":
                    sortedList = dataSource.OrderByDescending(opera => opera.Idk).ToList();
                    break;
                case "Esc":
                    sortedList = dataSource.OrderByDescending(opera => opera.Esc).ToList();
                    break;
                case "Grp":
                    sortedList = dataSource.OrderByDescending(opera => opera.Grp).ToList();
                    break;
                case "Ogtd":
                    sortedList = dataSource.OrderByDescending(opera => opera.Ogtd).ToList();
                    break;
                case "Sgti":
                    sortedList = dataSource.OrderByDescending(opera => opera.Sgti).ToList();
                    break;
                case "Pvcp":
                    sortedList = dataSource.OrderByDescending(opera => opera.Pvcp).ToList();
                    break;
                case "Pvcn":
                    sortedList = dataSource.OrderByDescending(opera => opera.Pvcn).ToList();
                    break;
                case "Pvcc":
                    sortedList = dataSource.OrderByDescending(opera => opera.Pvcc).ToList();
                    break;
                case "Ldct":
                    sortedList = dataSource.OrderByDescending(opera => opera.Ldct).ToList();
                    break;
                case "Ldcq":
                    sortedList = dataSource.OrderByDescending(opera => opera.Ldcq).ToList();
                    break;
                case "Ldcn":
                    sortedList = dataSource.OrderByDescending(opera => opera.Ldcn).ToList();
                    break;
                case "Ldcu":
                    sortedList = dataSource.OrderByDescending(opera => opera.Ldcu).ToList();
                    break;
                case "Ldcm":
                    sortedList = dataSource.OrderByDescending(opera => opera.Ldcm).ToList();
                    break;
                case "Cold":
                    sortedList = dataSource.OrderByDescending(opera => opera.Cold).ToList();
                    break;
                case "Dtsi":
                    sortedList = dataSource.OrderByDescending(opera => opera.Dtsi).ToList();
                    break;
                case "Autn":
                    sortedList = dataSource.OrderByDescending(opera => opera.Autn).ToList();
                    break;
                case "Atbd":
                    sortedList = dataSource.OrderByDescending(opera => opera.Atbd).ToList();
                    break;
                case "Mtc":
                    sortedList = dataSource.OrderByDescending(opera => opera.Mtc).ToList();
                    break;
                case "Stcc":
                    sortedList = dataSource.OrderByDescending(opera => opera.Stcc).ToList();
                    break;
                case "Cdgg":
                    sortedList = dataSource.OrderByDescending(opera => opera.Cdgg).ToList();
                    break;
                case "Fur":
                    sortedList = dataSource.OrderByDescending(opera => opera.Fur).ToList();
                    break;
                default:
                    break;
            }
            return sortedList;
        }

        private bool isSiglaValida(string sigla)
        {
 
            string[] validSigle = new string[] { "Idk", "Esc", "Grp", "Ogtd", "Sgti", "Pvcp", "Pvcn", "Pvcc", "Ldct",
                                           "Ldcq", "Ldcn", "Ldcu", "Ldcm", "Dtsi", "Autn",
                                           "Atbd", "Mtc", "Stcc", "Cdgg", "Fur" };

            return validSigle.Contains(sigla);

        }

        public void ContaOpere()
        {
            labelOpere.Text = "Numero opere: " + ((List<Opera>)grigliaOpere.DataSource).Count;
        }
    }
}
