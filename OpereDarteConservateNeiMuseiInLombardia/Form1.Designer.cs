namespace OpereDarteConservateNeiMuseiInLombardia
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.grigliaOpere = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_ricerche = new System.Windows.Forms.Button();
            this.btn_filtri = new System.Windows.Forms.Button();
            this.btn_cercaOperaPerID = new System.Windows.Forms.Button();
            this.btn_cercaOperaPerAutore = new System.Windows.Forms.Button();
            this.pnl_bottoni = new System.Windows.Forms.Panel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btn_filtraPerFornitore = new System.Windows.Forms.Button();
            this.btn_filtraPerMateriale = new System.Windows.Forms.Button();
            this.btn_filtraPerProprieta = new System.Windows.Forms.Button();
            this.btn_filtraPerStatoDiConservazione = new System.Windows.Forms.Button();
            this.btn_filtraPerEnte = new System.Windows.Forms.Button();
            this.btn_filtraPerTipoDiEdificio = new System.Windows.Forms.Button();
            this.btn_filtraPerProvincia = new System.Windows.Forms.Button();
            this.btn_filtraPerComune = new System.Windows.Forms.Button();
            this.btn_filtraPerGruppo = new System.Windows.Forms.Button();
            this.btn_filtraPerMuseo = new System.Windows.Forms.Button();
            this.btn_filtraPerSecolo = new System.Windows.Forms.Button();
            this.btn_filtraOperePerTipologia = new System.Windows.Forms.Button();
            this.btn_caricaCatalogo = new System.Windows.Forms.Button();
            this.btn_CercaOperaPerDescrizione = new System.Windows.Forms.Button();
            this.btn_cercaOperaPerSoggetto = new System.Windows.Forms.Button();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.btn_mappa = new System.Windows.Forms.Button();
            this.btn_cercaImmagine = new System.Windows.Forms.Button();
            this.btn_cercaMuseo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grigliaOpere)).BeginInit();
            this.pnl_bottoni.SuspendLayout();
            this.SuspendLayout();
            // 
            // grigliaOpere
            // 
            this.grigliaOpere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grigliaOpere.Location = new System.Drawing.Point(404, 14);
            this.grigliaOpere.Margin = new System.Windows.Forms.Padding(4);
            this.grigliaOpere.Name = "grigliaOpere";
            this.grigliaOpere.RowHeadersWidth = 51;
            this.grigliaOpere.Size = new System.Drawing.Size(1519, 1039);
            this.grigliaOpere.TabIndex = 0;
            this.grigliaOpere.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grigliaOpere_KeyDown);
            // 
            // btn_ricerche
            // 
            this.btn_ricerche.Location = new System.Drawing.Point(12, 27);
            this.btn_ricerche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ricerche.Name = "btn_ricerche";
            this.btn_ricerche.Size = new System.Drawing.Size(121, 54);
            this.btn_ricerche.TabIndex = 1;
            this.btn_ricerche.Text = "Ricerche";
            this.btn_ricerche.UseVisualStyleBackColor = true;
            this.btn_ricerche.Click += new System.EventHandler(this.btn_ricerche_Click);
            // 
            // btn_filtri
            // 
            this.btn_filtri.Location = new System.Drawing.Point(141, 27);
            this.btn_filtri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_filtri.Name = "btn_filtri";
            this.btn_filtri.Size = new System.Drawing.Size(121, 54);
            this.btn_filtri.TabIndex = 2;
            this.btn_filtri.Text = "Filtri";
            this.btn_filtri.UseVisualStyleBackColor = true;
            this.btn_filtri.Click += new System.EventHandler(this.btn_filtri_Click);
            // 
            // btn_cercaOperaPerID
            // 
            this.btn_cercaOperaPerID.Location = new System.Drawing.Point(12, 100);
            this.btn_cercaOperaPerID.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cercaOperaPerID.Name = "btn_cercaOperaPerID";
            this.btn_cercaOperaPerID.Size = new System.Drawing.Size(384, 53);
            this.btn_cercaOperaPerID.TabIndex = 3;
            this.btn_cercaOperaPerID.Text = "Cerca opera per ID";
            this.btn_cercaOperaPerID.UseVisualStyleBackColor = true;
            this.btn_cercaOperaPerID.Click += new System.EventHandler(this.btn_cercaOperaPerID_Click);
            // 
            // btn_cercaOperaPerAutore
            // 
            this.btn_cercaOperaPerAutore.Location = new System.Drawing.Point(12, 160);
            this.btn_cercaOperaPerAutore.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cercaOperaPerAutore.Name = "btn_cercaOperaPerAutore";
            this.btn_cercaOperaPerAutore.Size = new System.Drawing.Size(384, 53);
            this.btn_cercaOperaPerAutore.TabIndex = 4;
            this.btn_cercaOperaPerAutore.Text = "Cerca opera per autore";
            this.btn_cercaOperaPerAutore.UseVisualStyleBackColor = true;
            this.btn_cercaOperaPerAutore.Click += new System.EventHandler(this.btn_cercaOperaPerAutore_Click);
            // 
            // pnl_bottoni
            // 
            this.pnl_bottoni.Controls.Add(this.btn_filtraPerFornitore);
            this.pnl_bottoni.Controls.Add(this.btn_filtraPerMateriale);
            this.pnl_bottoni.Controls.Add(this.btn_filtraPerProprieta);
            this.pnl_bottoni.Controls.Add(this.btn_filtraPerStatoDiConservazione);
            this.pnl_bottoni.Controls.Add(this.btn_filtraPerEnte);
            this.pnl_bottoni.Controls.Add(this.btn_filtraPerTipoDiEdificio);
            this.pnl_bottoni.Controls.Add(this.btn_filtraPerProvincia);
            this.pnl_bottoni.Controls.Add(this.btn_filtraPerComune);
            this.pnl_bottoni.Controls.Add(this.btn_filtraPerGruppo);
            this.pnl_bottoni.Controls.Add(this.btn_filtraPerMuseo);
            this.pnl_bottoni.Controls.Add(this.btn_filtraPerSecolo);
            this.pnl_bottoni.Controls.Add(this.btn_filtraOperePerTipologia);
            this.pnl_bottoni.Location = new System.Drawing.Point(9, 87);
            this.pnl_bottoni.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_bottoni.Name = "pnl_bottoni";
            this.pnl_bottoni.Size = new System.Drawing.Size(387, 898);
            this.pnl_bottoni.TabIndex = 6;
            this.pnl_bottoni.Visible = false;
            this.pnl_bottoni.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_bottoni_Paint);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(404, 14);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1519, 1039);
            this.webBrowser.TabIndex = 13;
            // 
            // btn_filtraPerFornitore
            // 
            this.btn_filtraPerFornitore.Location = new System.Drawing.Point(4, 677);
            this.btn_filtraPerFornitore.Margin = new System.Windows.Forms.Padding(4);
            this.btn_filtraPerFornitore.Name = "btn_filtraPerFornitore";
            this.btn_filtraPerFornitore.Size = new System.Drawing.Size(379, 53);
            this.btn_filtraPerFornitore.TabIndex = 18;
            this.btn_filtraPerFornitore.Text = "Filtra per fornitore";
            this.btn_filtraPerFornitore.UseVisualStyleBackColor = true;
            this.btn_filtraPerFornitore.Click += new System.EventHandler(this.btn_filtraPerFornitore_Click);
            // 
            // btn_filtraPerMateriale
            // 
            this.btn_filtraPerMateriale.Location = new System.Drawing.Point(4, 436);
            this.btn_filtraPerMateriale.Margin = new System.Windows.Forms.Padding(4);
            this.btn_filtraPerMateriale.Name = "btn_filtraPerMateriale";
            this.btn_filtraPerMateriale.Size = new System.Drawing.Size(379, 53);
            this.btn_filtraPerMateriale.TabIndex = 17;
            this.btn_filtraPerMateriale.Text = "Filtra per materiale";
            this.btn_filtraPerMateriale.UseVisualStyleBackColor = true;
            this.btn_filtraPerMateriale.Click += new System.EventHandler(this.btn_filtraPerMateriale_Click);
            // 
            // btn_filtraPerProprieta
            // 
            this.btn_filtraPerProprieta.Location = new System.Drawing.Point(4, 616);
            this.btn_filtraPerProprieta.Margin = new System.Windows.Forms.Padding(4);
            this.btn_filtraPerProprieta.Name = "btn_filtraPerProprieta";
            this.btn_filtraPerProprieta.Size = new System.Drawing.Size(379, 53);
            this.btn_filtraPerProprieta.TabIndex = 16;
            this.btn_filtraPerProprieta.Text = "Filtra per proprietà";
            this.btn_filtraPerProprieta.UseVisualStyleBackColor = true;
            this.btn_filtraPerProprieta.Click += new System.EventHandler(this.btn_filtraPerProprieta_Click);
            // 
            // btn_filtraPerStatoDiConservazione
            // 
            this.btn_filtraPerStatoDiConservazione.Location = new System.Drawing.Point(4, 375);
            this.btn_filtraPerStatoDiConservazione.Margin = new System.Windows.Forms.Padding(4);
            this.btn_filtraPerStatoDiConservazione.Name = "btn_filtraPerStatoDiConservazione";
            this.btn_filtraPerStatoDiConservazione.Size = new System.Drawing.Size(379, 53);
            this.btn_filtraPerStatoDiConservazione.TabIndex = 15;
            this.btn_filtraPerStatoDiConservazione.Text = "Filtra per stato di conservazione";
            this.btn_filtraPerStatoDiConservazione.UseVisualStyleBackColor = true;
            this.btn_filtraPerStatoDiConservazione.Click += new System.EventHandler(this.btn_filtraPerStatoDiConservazione_Click);
            // 
            // btn_filtraPerEnte
            // 
            this.btn_filtraPerEnte.Location = new System.Drawing.Point(4, 555);
            this.btn_filtraPerEnte.Margin = new System.Windows.Forms.Padding(4);
            this.btn_filtraPerEnte.Name = "btn_filtraPerEnte";
            this.btn_filtraPerEnte.Size = new System.Drawing.Size(379, 53);
            this.btn_filtraPerEnte.TabIndex = 14;
            this.btn_filtraPerEnte.Text = "Filtra per ente";
            this.btn_filtraPerEnte.UseVisualStyleBackColor = true;
            this.btn_filtraPerEnte.Click += new System.EventHandler(this.btn_filtraPerEnte_Click);
            // 
            // btn_filtraPerTipoDiEdificio
            // 
            this.btn_filtraPerTipoDiEdificio.Location = new System.Drawing.Point(4, 314);
            this.btn_filtraPerTipoDiEdificio.Margin = new System.Windows.Forms.Padding(4);
            this.btn_filtraPerTipoDiEdificio.Name = "btn_filtraPerTipoDiEdificio";
            this.btn_filtraPerTipoDiEdificio.Size = new System.Drawing.Size(379, 53);
            this.btn_filtraPerTipoDiEdificio.TabIndex = 13;
            this.btn_filtraPerTipoDiEdificio.Text = "Filtra per tipo di edificio";
            this.btn_filtraPerTipoDiEdificio.UseVisualStyleBackColor = true;
            this.btn_filtraPerTipoDiEdificio.Click += new System.EventHandler(this.btn_filtraPerTipoDiEdificio_Click);
            // 
            // btn_filtraPerProvincia
            // 
            this.btn_filtraPerProvincia.Location = new System.Drawing.Point(4, 497);
            this.btn_filtraPerProvincia.Margin = new System.Windows.Forms.Padding(4);
            this.btn_filtraPerProvincia.Name = "btn_filtraPerProvincia";
            this.btn_filtraPerProvincia.Size = new System.Drawing.Size(379, 53);
            this.btn_filtraPerProvincia.TabIndex = 12;
            this.btn_filtraPerProvincia.Text = "Filtra per provincia";
            this.btn_filtraPerProvincia.UseVisualStyleBackColor = true;
            this.btn_filtraPerProvincia.Click += new System.EventHandler(this.btn_filtraPerProvincia_Click);
            // 
            // btn_filtraPerComune
            // 
            this.btn_filtraPerComune.Location = new System.Drawing.Point(4, 256);
            this.btn_filtraPerComune.Margin = new System.Windows.Forms.Padding(4);
            this.btn_filtraPerComune.Name = "btn_filtraPerComune";
            this.btn_filtraPerComune.Size = new System.Drawing.Size(379, 53);
            this.btn_filtraPerComune.TabIndex = 11;
            this.btn_filtraPerComune.Text = "Filtra per comune";
            this.btn_filtraPerComune.UseVisualStyleBackColor = true;
            this.btn_filtraPerComune.Click += new System.EventHandler(this.btn_filtraPerComune_Click);
            // 
            // btn_filtraPerGruppo
            // 
            this.btn_filtraPerGruppo.Location = new System.Drawing.Point(3, 195);
            this.btn_filtraPerGruppo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_filtraPerGruppo.Name = "btn_filtraPerGruppo";
            this.btn_filtraPerGruppo.Size = new System.Drawing.Size(380, 53);
            this.btn_filtraPerGruppo.TabIndex = 10;
            this.btn_filtraPerGruppo.Text = "Filtra per gruppo";
            this.btn_filtraPerGruppo.UseVisualStyleBackColor = true;
            this.btn_filtraPerGruppo.Click += new System.EventHandler(this.btn_filtraPerGruppo_Click);
            // 
            // btn_filtraPerMuseo
            // 
            this.btn_filtraPerMuseo.Location = new System.Drawing.Point(3, 134);
            this.btn_filtraPerMuseo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_filtraPerMuseo.Name = "btn_filtraPerMuseo";
            this.btn_filtraPerMuseo.Size = new System.Drawing.Size(380, 53);
            this.btn_filtraPerMuseo.TabIndex = 9;
            this.btn_filtraPerMuseo.Text = "Filtra per museo";
            this.btn_filtraPerMuseo.UseVisualStyleBackColor = true;
            this.btn_filtraPerMuseo.Click += new System.EventHandler(this.btn_filtraPerMuseo_Click);
            // 
            // btn_filtraPerSecolo
            // 
            this.btn_filtraPerSecolo.Location = new System.Drawing.Point(2, 73);
            this.btn_filtraPerSecolo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_filtraPerSecolo.Name = "btn_filtraPerSecolo";
            this.btn_filtraPerSecolo.Size = new System.Drawing.Size(381, 53);
            this.btn_filtraPerSecolo.TabIndex = 8;
            this.btn_filtraPerSecolo.Text = "Filtra per secolo";
            this.btn_filtraPerSecolo.UseVisualStyleBackColor = true;
            this.btn_filtraPerSecolo.Click += new System.EventHandler(this.btn_filtraPerSecolo_Click);
            // 
            // btn_filtraOperePerTipologia
            // 
            this.btn_filtraOperePerTipologia.Location = new System.Drawing.Point(3, 12);
            this.btn_filtraOperePerTipologia.Margin = new System.Windows.Forms.Padding(4);
            this.btn_filtraOperePerTipologia.Name = "btn_filtraOperePerTipologia";
            this.btn_filtraOperePerTipologia.Size = new System.Drawing.Size(380, 53);
            this.btn_filtraOperePerTipologia.TabIndex = 7;
            this.btn_filtraOperePerTipologia.Text = "Filtra opere per tipologia";
            this.btn_filtraOperePerTipologia.UseVisualStyleBackColor = true;
            this.btn_filtraOperePerTipologia.Click += new System.EventHandler(this.btn_filtraOperePerTipologia_Click);
            // 
            // btn_caricaCatalogo
            // 
            this.btn_caricaCatalogo.Location = new System.Drawing.Point(9, 993);
            this.btn_caricaCatalogo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_caricaCatalogo.Name = "btn_caricaCatalogo";
            this.btn_caricaCatalogo.Size = new System.Drawing.Size(172, 49);
            this.btn_caricaCatalogo.TabIndex = 8;
            this.btn_caricaCatalogo.Text = "Carica catalogo completo";
            this.btn_caricaCatalogo.UseVisualStyleBackColor = true;
            this.btn_caricaCatalogo.Click += new System.EventHandler(this.btn_caricaCatalogo_Click);
            // 
            // btn_CercaOperaPerDescrizione
            // 
            this.btn_CercaOperaPerDescrizione.Location = new System.Drawing.Point(12, 221);
            this.btn_CercaOperaPerDescrizione.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CercaOperaPerDescrizione.Name = "btn_CercaOperaPerDescrizione";
            this.btn_CercaOperaPerDescrizione.Size = new System.Drawing.Size(384, 53);
            this.btn_CercaOperaPerDescrizione.TabIndex = 9;
            this.btn_CercaOperaPerDescrizione.Text = "Cerca opera per descrizione";
            this.btn_CercaOperaPerDescrizione.UseVisualStyleBackColor = true;
            this.btn_CercaOperaPerDescrizione.Click += new System.EventHandler(this.btn_CercaOperaPerDescrizione_Click);
            // 
            // btn_cercaOperaPerSoggetto
            // 
            this.btn_cercaOperaPerSoggetto.Location = new System.Drawing.Point(12, 282);
            this.btn_cercaOperaPerSoggetto.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cercaOperaPerSoggetto.Name = "btn_cercaOperaPerSoggetto";
            this.btn_cercaOperaPerSoggetto.Size = new System.Drawing.Size(384, 53);
            this.btn_cercaOperaPerSoggetto.TabIndex = 10;
            this.btn_cercaOperaPerSoggetto.Text = "Cerca opera per soggetto";
            this.btn_cercaOperaPerSoggetto.UseVisualStyleBackColor = true;
            this.btn_cercaOperaPerSoggetto.Click += new System.EventHandler(this.btn_cercaOperaPerSoggetto_Click);
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(404, 14);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 2;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(1519, 1039);
            this.gmap.TabIndex = 11;
            this.gmap.Zoom = 0D;
            // 
            // btn_mappa
            // 
            this.btn_mappa.Location = new System.Drawing.Point(268, 27);
            this.btn_mappa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_mappa.Name = "btn_mappa";
            this.btn_mappa.Size = new System.Drawing.Size(121, 54);
            this.btn_mappa.TabIndex = 12;
            this.btn_mappa.Text = "Mappa";
            this.btn_mappa.UseVisualStyleBackColor = true;
            this.btn_mappa.Click += new System.EventHandler(this.btn_mappa_Click);
            // 
            // btn_cercaImmagine
            // 
            this.btn_cercaImmagine.Location = new System.Drawing.Point(12, 343);
            this.btn_cercaImmagine.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cercaImmagine.Name = "btn_cercaImmagine";
            this.btn_cercaImmagine.Size = new System.Drawing.Size(384, 53);
            this.btn_cercaImmagine.TabIndex = 14;
            this.btn_cercaImmagine.Text = "Cerca immagine dell\'opera";
            this.btn_cercaImmagine.UseVisualStyleBackColor = true;
            this.btn_cercaImmagine.Click += new System.EventHandler(this.btn_cercaImmagine_Click);
            // 
            // btn_cercaMuseo
            // 
            this.btn_cercaMuseo.Location = new System.Drawing.Point(13, 404);
            this.btn_cercaMuseo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cercaMuseo.Name = "btn_cercaMuseo";
            this.btn_cercaMuseo.Size = new System.Drawing.Size(384, 53);
            this.btn_cercaMuseo.TabIndex = 15;
            this.btn_cercaMuseo.Text = "Cerca museo sulla mappa";
            this.btn_cercaMuseo.UseVisualStyleBackColor = true;
            this.btn_cercaMuseo.Click += new System.EventHandler(this.btn_cercaMuseo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pnl_bottoni);
            this.Controls.Add(this.btn_cercaMuseo);
            this.Controls.Add(this.btn_cercaImmagine);
            this.Controls.Add(this.btn_mappa);
            this.Controls.Add(this.btn_cercaOperaPerSoggetto);
            this.Controls.Add(this.btn_CercaOperaPerDescrizione);
            this.Controls.Add(this.btn_caricaCatalogo);
            this.Controls.Add(this.btn_cercaOperaPerAutore);
            this.Controls.Add(this.btn_cercaOperaPerID);
            this.Controls.Add(this.btn_filtri);
            this.Controls.Add(this.btn_ricerche);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.grigliaOpere);
            this.Controls.Add(this.gmap);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grigliaOpere)).EndInit();
            this.pnl_bottoni.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grigliaOpere;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_ricerche;
        private System.Windows.Forms.Button btn_filtri;
        private System.Windows.Forms.Button btn_cercaOperaPerID;
        private System.Windows.Forms.Button btn_cercaOperaPerAutore;
        private System.Windows.Forms.Panel pnl_bottoni;
        private System.Windows.Forms.Button btn_filtraPerMuseo;
        private System.Windows.Forms.Button btn_filtraPerSecolo;
        private System.Windows.Forms.Button btn_filtraOperePerTipologia;
        private System.Windows.Forms.Button btn_caricaCatalogo;
        private System.Windows.Forms.Button btn_filtraPerGruppo;
        private System.Windows.Forms.Button btn_filtraPerProvincia;
        private System.Windows.Forms.Button btn_filtraPerComune;
        private System.Windows.Forms.Button btn_filtraPerEnte;
        private System.Windows.Forms.Button btn_filtraPerTipoDiEdificio;
        private System.Windows.Forms.Button btn_filtraPerProprieta;
        private System.Windows.Forms.Button btn_filtraPerStatoDiConservazione;
        private System.Windows.Forms.Button btn_filtraPerFornitore;
        private System.Windows.Forms.Button btn_filtraPerMateriale;
        private System.Windows.Forms.Button btn_CercaOperaPerDescrizione;
        private System.Windows.Forms.Button btn_cercaOperaPerSoggetto;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Button btn_mappa;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button btn_cercaImmagine;
        private System.Windows.Forms.Button btn_cercaMuseo;
    }
}

