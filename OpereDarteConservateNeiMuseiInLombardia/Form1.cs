using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using Microsoft.VisualBasic;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;

namespace OpereDarteConservateNeiMuseiInLombardia
{
    public partial class Form1 : Form
    {
        Catalogo catalogo;
        List<Opera> operes = new List<Opera>();
        private bool isFullScreen = false;  // Variabile di stato per tenere traccia della modalità schermo intero
        private FormBorderStyle prevFormBorderStyle;
        private FormWindowState prevWindowState;
        private Rectangle prevBounds;
        public Form1()
        {
            InitializeComponent();
            catalogo = new Catalogo(this);
            this.KeyPreview = true;
        }

        Dictionary<string, string> descrizioniSigle = new Dictionary<string, string>()
        {
            { "Idk", "codice" }
        };

       
        private void Form1_Load(object sender, EventArgs e)
        {
            catalogo.LeggiFile();
            grigliaOpere.DataSource = catalogo.opere;
            //grigliaOpere.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //grigliaOpere.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grigliaOpere.ReadOnly = true;
            gmap.Visible = false;
            webBrowser.Visible = false;

            InitializeMap();
        }

        private void grigliaOpere_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ricerche_Click(object sender, EventArgs e)
        {
            pnl_bottoni.Visible = false;
        }

        private void btn_filtri_Click(object sender, EventArgs e)
        {
            pnl_bottoni.Visible = true;
        }

        private void btn_cercaOperaPerAutore_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.CercaOperaPerAutore();
            MostraGriglia();

        }

        private void btn_cercaOperaPerID_Click(object sender, EventArgs e)
        {
            int risultato = catalogo.CercaOperaPerID();
            if (risultato != -1)
            {
                MessageBox.Show("Opera trovata all'indice: " + risultato);
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
            grigliaOpere.DataSource = catalogo.CercaOperaPerDescrizione();
            MostraGriglia();
        }

        private void btn_cercaImmagine_Click(object sender, EventArgs e)
        {
            int risultato = catalogo.CercaImmagine();
            if (risultato != -1)
            {
                string url = catalogo.opere[risultato].Url;
                webBrowser.Navigate(url);
                webBrowser.Visible = true;
                MostraGriglia();
            }
            else
            {
                MessageBox.Show("Opera non trovata.");
            }
        }

        private void btn_filtraOperePerTipologia_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.FiltraPerTipologia();
            MostraGriglia();
        }

        private void btn_filtraPerSecolo_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.FiltraPerSecolo();
            MostraGriglia();
        }

        private void btn_filtraPerMuseo_Click(object sender, EventArgs e)
        {
            
            grigliaOpere.DataSource = catalogo.FiltraPerMuseo();
            MostraGriglia();

        }

        private void pnl_bottoni_Paint(object sender, PaintEventArgs e)
        {

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
            grigliaOpere.Visible = true;

        }

        private void btn_filtraPerGruppo_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.FiltraPerGruppo();
            MostraGriglia();
        }

        private void btn_filtraPerComune_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.FiltraPerComune();
            MostraGriglia();
        }

        private void btn_filtraPerProvincia_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.FiltraPerProvincia();
            MostraGriglia();
        }


        private void btn_filtraPerEnte_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.FiltraPerEnte();
            MostraGriglia();
        }

        private void btn_filtraPerTipoDiEdificio_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.FiltraPerTipoDiEdificio();
            MostraGriglia();
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

        private void btn_filtraPerStatoDiConservazione_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.FiltraPerStatoDiConservazione();
            MostraGriglia();
        }

        private void btn_filtraPerProprieta_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.FiltraPerProprieta();
            MostraGriglia();

        }

        private void btn_filtraPerMateriale_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.FiltraPerMateriale();
            MostraGriglia();
        }

        private void btn_filtraPerFornitore_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.FiltraPerFornitore();
            MostraGriglia();
        }

        private void btn_cercaOperaPerSoggetto_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.CercaOperaPerSoggetto();
            MostraGriglia();

        }

        private void InitializeMap()
        {
            // Imposta il provider della mappa
            gmap.MapProvider = GMapProviders.GoogleMap;

            // Imposta le coordinate iniziali della mappa
            gmap.Position = new PointLatLng(45.4654219, 9.1859243); // Milano, Italia

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

            foreach(var opera in catalogo.opere)
            {
                if(locationUniche.Add(opera.Location))
                {
                    catalogoSenzaDuplicati.Add(opera);
                }
            }

            for (int i = 0; i < catalogoSenzaDuplicati.Count; i++)
            {
                var marker = new GMarkerGoogle(ConvertiCoordinate(catalogoSenzaDuplicati[i].Location), GMarkerGoogleType.red_dot);
                markersOverlay.Markers.Add(marker);
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
            
            if(gmap.Visible)
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
            if(gmap.Visible == true || webBrowser.Visible == true)
            {
                gmap.Visible = false;
                webBrowser.Visible = false;
                grigliaOpere.Visible = true;
            }
        }

        private void btn_cercaMuseo_Click(object sender, EventArgs e)
        {
            int risultato = catalogo.CercaMuseo();
            if (risultato != -1)
            {
                //MessageBox.Show("Opera trovata all'indice: " + risultato);
                gmap.Position = ConvertiCoordinate(catalogo.opere[risultato].Location);
                gmap.Zoom = 18;
                gmap.Visible = true;
                grigliaOpere.Visible = false;
                webBrowser.Visible = false;
            }
            else
            {
                MessageBox.Show("Opera non trovata.");
            }
        }
    }
}
