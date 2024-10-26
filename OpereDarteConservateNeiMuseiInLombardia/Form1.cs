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
            int risultato = catalogo.CercaOperaPerAutore();
            if (risultato != -1)
            {
                MessageBox.Show("Opera trovata all'indice: " + risultato);
                grigliaOpere.ClearSelection();
                grigliaOpere.FirstDisplayedScrollingRowIndex = risultato;
            }
            else
            {
                MessageBox.Show("Opera non trovata.");
            }
        }

        private void btn_cercaOperaPerID_Click(object sender, EventArgs e)
        {
            int risultato = catalogo.CercaOperaPerID();
            if (risultato != -1)
            {
                MessageBox.Show("Opera trovata all'indice: " + risultato);
                grigliaOpere.ClearSelection();
                grigliaOpere.FirstDisplayedScrollingRowIndex = risultato;
            }
            else
            {
                MessageBox.Show("Opera non trovata.");
            }
        }
        private void btn_CercaOperaPerDescrizione_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.CercaOperaPerDescrizione();
        }

        private void btn_filtraOperePerTipologia_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.FiltraPerTipologia();
        }

        private void btn_filtraPerSecolo_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.FiltraPerSecolo();
        }

        private void btn_filtraPerMuseo_Click(object sender, EventArgs e)
        {
            
            grigliaOpere.DataSource = catalogo.FiltraPerMuseo(); 

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
        }

        private void btn_filtraPerGruppo_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.FiltraPerGruppo();

        }

        private void btn_filtraPerComune_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.FiltraPerComune();

        }

        private void btn_filtraPerProvincia_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.FiltraPerProvincia();

        }


        private void btn_filtraPerEnte_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.FiltraPerEnte();

        }

        private void btn_filtraPerTipoDiEdificio_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.FiltraPerTipoDiEdificio();

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
        }

        private void btn_filtraPerProprieta_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.FiltraPerProprieta();

        }

        private void btn_filtraPerMateriale_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.FiltraPerMateriale();
        }

        private void btn_filtraPerFornitore_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.FiltraPerFornitore();
        }

        private void btn_cercaOperaPerSoggetto_Click(object sender, EventArgs e)
        {
            grigliaOpere.DataSource = catalogo.CercaOperaPerSoggetto();

        }

        private void LoadMapWithMarkers()
        {
            // Costruisci HTML e JavaScript per Google Maps con 200 marker
            var sb = new StringBuilder();
            sb.Append(@"
                <!DOCTYPE html>
                <html>
                <head>
                    <title>Google Maps con Marker</title>
                    <script src='https://maps.googleapis.com/maps/api/js?key=YOUR_API_KEY'></script>
                    <script>
                        function initMap() {
                            const map = new google.maps.Map(document.getElementById('map'), {
                                center: { lat: 45.4654219, lng: 12.4964 }, // Centro su Roma, per esempio
                                zoom: 5
                            });

                            const markers = [
            ");

            // Genera 200 marker casuali
            var random = new Random();
            for (int i = 0; i < 200; i++)
            {
                double lat = 41.0 + random.NextDouble(); // Latitudine casuale vicino a Roma
                double lng = 12.0 + random.NextDouble(); // Longitudine casuale vicino a Roma
                string title = $"Marker {i + 1}";

                sb.Append($@"{{ lat: {lat}, lng: {lng}, title: '{title}' }},");
            }

            sb.Append(@"];
                            markers.forEach(markerData => {
                                new google.maps.Marker({
                                    position: { lat: markerData.lat, lng: markerData.lng },
                                    map: map,
                                    title: markerData.title
                                });
                            });
                        }
                    </script>
                </head>
                <body onload='initMap()'>
                    <div id='map' style='width: 100%; height: 100%;'></div>
                </body>
                </html>
            ");

            // Carica il contenuto HTML nel controllo WebBrowser
            webBrowser.DocumentText = sb.ToString();
        }
        private void InitializeMap()
        {
            // Imposta il provider della mappa
            gmap.MapProvider = GMapProviders.GoogleMap;

            // Imposta le coordinate iniziali della mappa
            gmap.Position = new PointLatLng(45.4654219, 9.1859243); // Milano, Italia

            // Imposta zoom
            gmap.MinZoom = 2;
            gmap.MaxZoom = 18;
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
            }
            else
            {
                gmap.Visible = true;
            }
        }

        
    }
}
