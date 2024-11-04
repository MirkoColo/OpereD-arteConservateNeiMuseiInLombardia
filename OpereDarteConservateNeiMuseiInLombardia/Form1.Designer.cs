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
            this.btn_cercaOperaPerID = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btn_caricaCatalogo = new System.Windows.Forms.Button();
            this.btn_CercaOperaPerDescrizione = new System.Windows.Forms.Button();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.btn_mappa = new System.Windows.Forms.Button();
            this.btn_cercaImmagine = new System.Windows.Forms.Button();
            this.btn_cercaMuseo = new System.Windows.Forms.Button();
            this.btn_cercaEventi = new System.Windows.Forms.Button();
            this.btn_mostraBrowser = new System.Windows.Forms.Button();
            this.btn_filtroDinamico = new System.Windows.Forms.Button();
            this.pnl_listBox = new System.Windows.Forms.Panel();
            this.btn_applicaFiltri = new System.Windows.Forms.Button();
            this.listaFiltroDin = new System.Windows.Forms.CheckedListBox();
            this.btn_cercaOperaPerSoggetto = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_crescente = new System.Windows.Forms.Button();
            this.btn_decrescente = new System.Windows.Forms.Button();
            this.labelOpere = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grigliaOpere)).BeginInit();
            this.pnl_listBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grigliaOpere
            // 
            this.grigliaOpere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grigliaOpere.Location = new System.Drawing.Point(434, 13);
            this.grigliaOpere.Margin = new System.Windows.Forms.Padding(4);
            this.grigliaOpere.Name = "grigliaOpere";
            this.grigliaOpere.RowHeadersWidth = 51;
            this.grigliaOpere.Size = new System.Drawing.Size(1519, 1039);
            this.grigliaOpere.TabIndex = 0;
            this.grigliaOpere.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grigliaOpere_ColumnHeaderMouseClick);
            this.grigliaOpere.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grigliaOpere_KeyDown);
            // 
            // btn_ricerche
            // 
            this.btn_ricerche.Location = new System.Drawing.Point(30, 13);
            this.btn_ricerche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ricerche.Name = "btn_ricerche";
            this.btn_ricerche.Size = new System.Drawing.Size(180, 54);
            this.btn_ricerche.TabIndex = 1;
            this.btn_ricerche.Text = "Ricerche";
            this.btn_ricerche.UseVisualStyleBackColor = true;
            this.btn_ricerche.Click += new System.EventHandler(this.btn_ricerche_Click);
            // 
            // btn_cercaOperaPerID
            // 
            this.btn_cercaOperaPerID.Location = new System.Drawing.Point(30, 86);
            this.btn_cercaOperaPerID.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cercaOperaPerID.Name = "btn_cercaOperaPerID";
            this.btn_cercaOperaPerID.Size = new System.Drawing.Size(376, 53);
            this.btn_cercaOperaPerID.TabIndex = 3;
            this.btn_cercaOperaPerID.Text = "Cerca opera per ID";
            this.btn_cercaOperaPerID.UseVisualStyleBackColor = true;
            this.btn_cercaOperaPerID.Click += new System.EventHandler(this.btn_cercaOperaPerID_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(434, 13);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1519, 1039);
            this.webBrowser.TabIndex = 13;
            // 
            // btn_caricaCatalogo
            // 
            this.btn_caricaCatalogo.Location = new System.Drawing.Point(30, 993);
            this.btn_caricaCatalogo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_caricaCatalogo.Name = "btn_caricaCatalogo";
            this.btn_caricaCatalogo.Size = new System.Drawing.Size(120, 49);
            this.btn_caricaCatalogo.TabIndex = 8;
            this.btn_caricaCatalogo.Text = "Carica catalogo completo";
            this.btn_caricaCatalogo.UseVisualStyleBackColor = true;
            this.btn_caricaCatalogo.Click += new System.EventHandler(this.btn_caricaCatalogo_Click);
            // 
            // btn_CercaOperaPerDescrizione
            // 
            this.btn_CercaOperaPerDescrizione.Location = new System.Drawing.Point(30, 147);
            this.btn_CercaOperaPerDescrizione.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CercaOperaPerDescrizione.Name = "btn_CercaOperaPerDescrizione";
            this.btn_CercaOperaPerDescrizione.Size = new System.Drawing.Size(376, 53);
            this.btn_CercaOperaPerDescrizione.TabIndex = 9;
            this.btn_CercaOperaPerDescrizione.Text = "Cerca opera per descrizione";
            this.btn_CercaOperaPerDescrizione.UseVisualStyleBackColor = true;
            this.btn_CercaOperaPerDescrizione.Click += new System.EventHandler(this.btn_CercaOperaPerDescrizione_Click);
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(434, 13);
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
            this.btn_mappa.Location = new System.Drawing.Point(161, 993);
            this.btn_mappa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_mappa.Name = "btn_mappa";
            this.btn_mappa.Size = new System.Drawing.Size(120, 49);
            this.btn_mappa.TabIndex = 12;
            this.btn_mappa.Text = "Mostra Mappa";
            this.btn_mappa.UseVisualStyleBackColor = true;
            this.btn_mappa.Click += new System.EventHandler(this.btn_mappa_Click);
            // 
            // btn_cercaImmagine
            // 
            this.btn_cercaImmagine.Location = new System.Drawing.Point(30, 269);
            this.btn_cercaImmagine.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cercaImmagine.Name = "btn_cercaImmagine";
            this.btn_cercaImmagine.Size = new System.Drawing.Size(376, 53);
            this.btn_cercaImmagine.TabIndex = 14;
            this.btn_cercaImmagine.Text = "Cerca immagine dell\'opera";
            this.btn_cercaImmagine.UseVisualStyleBackColor = true;
            this.btn_cercaImmagine.Click += new System.EventHandler(this.btn_cercaImmagine_Click);
            // 
            // btn_cercaMuseo
            // 
            this.btn_cercaMuseo.Location = new System.Drawing.Point(31, 330);
            this.btn_cercaMuseo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cercaMuseo.Name = "btn_cercaMuseo";
            this.btn_cercaMuseo.Size = new System.Drawing.Size(376, 53);
            this.btn_cercaMuseo.TabIndex = 15;
            this.btn_cercaMuseo.Text = "Cerca museo sulla mappa";
            this.btn_cercaMuseo.UseVisualStyleBackColor = true;
            this.btn_cercaMuseo.Click += new System.EventHandler(this.btn_cercaMuseo_Click);
            // 
            // btn_cercaEventi
            // 
            this.btn_cercaEventi.Location = new System.Drawing.Point(31, 391);
            this.btn_cercaEventi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cercaEventi.Name = "btn_cercaEventi";
            this.btn_cercaEventi.Size = new System.Drawing.Size(376, 53);
            this.btn_cercaEventi.TabIndex = 16;
            this.btn_cercaEventi.Text = "Cerca eventi ";
            this.btn_cercaEventi.UseVisualStyleBackColor = true;
            this.btn_cercaEventi.Click += new System.EventHandler(this.btn_cercaEventi_Click);
            // 
            // btn_mostraBrowser
            // 
            this.btn_mostraBrowser.Location = new System.Drawing.Point(290, 993);
            this.btn_mostraBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mostraBrowser.Name = "btn_mostraBrowser";
            this.btn_mostraBrowser.Size = new System.Drawing.Size(120, 49);
            this.btn_mostraBrowser.TabIndex = 17;
            this.btn_mostraBrowser.Text = "Mostra Browser";
            this.btn_mostraBrowser.UseVisualStyleBackColor = true;
            this.btn_mostraBrowser.Click += new System.EventHandler(this.btn_mostraBrowser_Click);
            // 
            // btn_filtroDinamico
            // 
            this.btn_filtroDinamico.Location = new System.Drawing.Point(226, 13);
            this.btn_filtroDinamico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_filtroDinamico.Name = "btn_filtroDinamico";
            this.btn_filtroDinamico.Size = new System.Drawing.Size(180, 54);
            this.btn_filtroDinamico.TabIndex = 18;
            this.btn_filtroDinamico.Text = "Filtro Dinamico";
            this.btn_filtroDinamico.UseVisualStyleBackColor = true;
            this.btn_filtroDinamico.Click += new System.EventHandler(this.btn_filtroDinamico_Click);
            // 
            // pnl_listBox
            // 
            this.pnl_listBox.Controls.Add(this.btn_applicaFiltri);
            this.pnl_listBox.Controls.Add(this.listaFiltroDin);
            this.pnl_listBox.Location = new System.Drawing.Point(30, 72);
            this.pnl_listBox.Name = "pnl_listBox";
            this.pnl_listBox.Size = new System.Drawing.Size(388, 448);
            this.pnl_listBox.TabIndex = 19;
            // 
            // btn_applicaFiltri
            // 
            this.btn_applicaFiltri.Location = new System.Drawing.Point(74, 392);
            this.btn_applicaFiltri.Name = "btn_applicaFiltri";
            this.btn_applicaFiltri.Size = new System.Drawing.Size(232, 34);
            this.btn_applicaFiltri.TabIndex = 1;
            this.btn_applicaFiltri.Text = "Applica Filtri";
            this.btn_applicaFiltri.UseVisualStyleBackColor = true;
            this.btn_applicaFiltri.Click += new System.EventHandler(this.btn_applicaFiltri_Click);
            // 
            // listaFiltroDin
            // 
            this.listaFiltroDin.FormattingEnabled = true;
            this.listaFiltroDin.Location = new System.Drawing.Point(3, 8);
            this.listaFiltroDin.Name = "listaFiltroDin";
            this.listaFiltroDin.Size = new System.Drawing.Size(373, 378);
            this.listaFiltroDin.TabIndex = 0;
            // 
            // btn_cercaOperaPerSoggetto
            // 
            this.btn_cercaOperaPerSoggetto.Location = new System.Drawing.Point(31, 208);
            this.btn_cercaOperaPerSoggetto.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cercaOperaPerSoggetto.Name = "btn_cercaOperaPerSoggetto";
            this.btn_cercaOperaPerSoggetto.Size = new System.Drawing.Size(376, 53);
            this.btn_cercaOperaPerSoggetto.TabIndex = 20;
            this.btn_cercaOperaPerSoggetto.Text = "Cerca opera per soggetto";
            this.btn_cercaOperaPerSoggetto.UseVisualStyleBackColor = true;
            this.btn_cercaOperaPerSoggetto.Click += new System.EventHandler(this.btn_cercaOperaPerSoggetto_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(101, 634);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(232, 24);
            this.comboBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 592);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ordinamento";
            // 
            // btn_crescente
            // 
            this.btn_crescente.Location = new System.Drawing.Point(90, 676);
            this.btn_crescente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_crescente.Name = "btn_crescente";
            this.btn_crescente.Size = new System.Drawing.Size(120, 49);
            this.btn_crescente.TabIndex = 23;
            this.btn_crescente.Text = "Crescente";
            this.btn_crescente.UseVisualStyleBackColor = true;
            this.btn_crescente.Click += new System.EventHandler(this.btn_crescente_Click);
            // 
            // btn_decrescente
            // 
            this.btn_decrescente.Location = new System.Drawing.Point(226, 676);
            this.btn_decrescente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_decrescente.Name = "btn_decrescente";
            this.btn_decrescente.Size = new System.Drawing.Size(120, 49);
            this.btn_decrescente.TabIndex = 24;
            this.btn_decrescente.Text = "Decrescente";
            this.btn_decrescente.UseVisualStyleBackColor = true;
            this.btn_decrescente.Click += new System.EventHandler(this.btn_decrescente_Click);
            // 
            // labelOpere
            // 
            this.labelOpere.AutoSize = true;
            this.labelOpere.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpere.Location = new System.Drawing.Point(119, 546);
            this.labelOpere.Name = "labelOpere";
            this.labelOpere.Size = new System.Drawing.Size(56, 20);
            this.labelOpere.TabIndex = 25;
            this.labelOpere.Text = "opere";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.labelOpere);
            this.Controls.Add(this.btn_decrescente);
            this.Controls.Add(this.btn_crescente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.pnl_listBox);
            this.Controls.Add(this.btn_filtroDinamico);
            this.Controls.Add(this.btn_mostraBrowser);
            this.Controls.Add(this.btn_cercaMuseo);
            this.Controls.Add(this.btn_cercaImmagine);
            this.Controls.Add(this.btn_mappa);
            this.Controls.Add(this.btn_CercaOperaPerDescrizione);
            this.Controls.Add(this.btn_caricaCatalogo);
            this.Controls.Add(this.btn_cercaOperaPerID);
            this.Controls.Add(this.btn_ricerche);
            this.Controls.Add(this.grigliaOpere);
            this.Controls.Add(this.gmap);
            this.Controls.Add(this.btn_cercaEventi);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.btn_cercaOperaPerSoggetto);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grigliaOpere)).EndInit();
            this.pnl_listBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grigliaOpere;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_ricerche;
        private System.Windows.Forms.Button btn_cercaOperaPerID;
        private System.Windows.Forms.Button btn_caricaCatalogo;
        private System.Windows.Forms.Button btn_CercaOperaPerDescrizione;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Button btn_mappa;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button btn_cercaImmagine;
        private System.Windows.Forms.Button btn_cercaMuseo;
        private System.Windows.Forms.Button btn_cercaEventi;
        private System.Windows.Forms.Button btn_mostraBrowser;
        private System.Windows.Forms.Button btn_filtroDinamico;
        private System.Windows.Forms.Panel pnl_listBox;
        private System.Windows.Forms.CheckedListBox listaFiltroDin;
        private System.Windows.Forms.Button btn_applicaFiltri;
        private System.Windows.Forms.Button btn_cercaOperaPerSoggetto;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_crescente;
        private System.Windows.Forms.Button btn_decrescente;
        private System.Windows.Forms.Label labelOpere;
    }
}

