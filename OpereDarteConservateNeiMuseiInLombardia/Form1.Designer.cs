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
            this.btn_cercaOperaPerTitolo = new System.Windows.Forms.Button();
            this.pnl_bottoni = new System.Windows.Forms.Panel();
            this.btn_filtraOperePerTipologia = new System.Windows.Forms.Button();
            this.btn_filtraPerPeriodoStorico = new System.Windows.Forms.Button();
            this.btn_filtraPerMuseo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grigliaOpere)).BeginInit();
            this.pnl_bottoni.SuspendLayout();
            this.SuspendLayout();
            // 
            // grigliaOpere
            // 
            this.grigliaOpere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grigliaOpere.Location = new System.Drawing.Point(220, 11);
            this.grigliaOpere.Name = "grigliaOpere";
            this.grigliaOpere.RowHeadersWidth = 51;
            this.grigliaOpere.Size = new System.Drawing.Size(958, 415);
            this.grigliaOpere.TabIndex = 0;
            this.grigliaOpere.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grigliaOpere_CellContentClick);
            this.grigliaOpere.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grigliaOpere_KeyDown);
            // 
            // btn_ricerche
            // 
            this.btn_ricerche.Location = new System.Drawing.Point(9, 22);
            this.btn_ricerche.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ricerche.Name = "btn_ricerche";
            this.btn_ricerche.Size = new System.Drawing.Size(91, 44);
            this.btn_ricerche.TabIndex = 1;
            this.btn_ricerche.Text = "Ricerche";
            this.btn_ricerche.UseVisualStyleBackColor = true;
            this.btn_ricerche.Click += new System.EventHandler(this.btn_ricerche_Click);
            // 
            // btn_filtri
            // 
            this.btn_filtri.Location = new System.Drawing.Point(115, 22);
            this.btn_filtri.Margin = new System.Windows.Forms.Padding(2);
            this.btn_filtri.Name = "btn_filtri";
            this.btn_filtri.Size = new System.Drawing.Size(91, 44);
            this.btn_filtri.TabIndex = 2;
            this.btn_filtri.Text = "Filtri";
            this.btn_filtri.UseVisualStyleBackColor = true;
            this.btn_filtri.Click += new System.EventHandler(this.btn_filtri_Click);
            // 
            // btn_cercaOperaPerID
            // 
            this.btn_cercaOperaPerID.Location = new System.Drawing.Point(12, 81);
            this.btn_cercaOperaPerID.Name = "btn_cercaOperaPerID";
            this.btn_cercaOperaPerID.Size = new System.Drawing.Size(194, 43);
            this.btn_cercaOperaPerID.TabIndex = 3;
            this.btn_cercaOperaPerID.Text = "Cerca opera per ID";
            this.btn_cercaOperaPerID.UseVisualStyleBackColor = true;
            this.btn_cercaOperaPerID.Click += new System.EventHandler(this.btn_cercaOperaPerID_Click);
            // 
            // btn_cercaOperaPerAutore
            // 
            this.btn_cercaOperaPerAutore.Location = new System.Drawing.Point(12, 198);
            this.btn_cercaOperaPerAutore.Name = "btn_cercaOperaPerAutore";
            this.btn_cercaOperaPerAutore.Size = new System.Drawing.Size(194, 43);
            this.btn_cercaOperaPerAutore.TabIndex = 4;
            this.btn_cercaOperaPerAutore.Text = "Cerca opera per autore";
            this.btn_cercaOperaPerAutore.UseVisualStyleBackColor = true;
            this.btn_cercaOperaPerAutore.Click += new System.EventHandler(this.btn_cercaOperaPerAutore_Click);
            // 
            // btn_cercaOperaPerTitolo
            // 
            this.btn_cercaOperaPerTitolo.Location = new System.Drawing.Point(12, 140);
            this.btn_cercaOperaPerTitolo.Name = "btn_cercaOperaPerTitolo";
            this.btn_cercaOperaPerTitolo.Size = new System.Drawing.Size(194, 43);
            this.btn_cercaOperaPerTitolo.TabIndex = 5;
            this.btn_cercaOperaPerTitolo.Text = "Cerca opera per titolo";
            this.btn_cercaOperaPerTitolo.UseVisualStyleBackColor = true;
            this.btn_cercaOperaPerTitolo.Click += new System.EventHandler(this.btn_cercaOperaPerTitolo_Click);
            // 
            // pnl_bottoni
            // 
            this.pnl_bottoni.Controls.Add(this.btn_filtraPerMuseo);
            this.pnl_bottoni.Controls.Add(this.btn_filtraPerPeriodoStorico);
            this.pnl_bottoni.Controls.Add(this.btn_filtraOperePerTipologia);
            this.pnl_bottoni.Location = new System.Drawing.Point(7, 71);
            this.pnl_bottoni.Name = "pnl_bottoni";
            this.pnl_bottoni.Size = new System.Drawing.Size(199, 197);
            this.pnl_bottoni.TabIndex = 6;
            this.pnl_bottoni.Visible = false;
            this.pnl_bottoni.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_bottoni_Paint);
            // 
            // btn_filtraOperePerTipologia
            // 
            this.btn_filtraOperePerTipologia.Location = new System.Drawing.Point(2, 10);
            this.btn_filtraOperePerTipologia.Name = "btn_filtraOperePerTipologia";
            this.btn_filtraOperePerTipologia.Size = new System.Drawing.Size(194, 43);
            this.btn_filtraOperePerTipologia.TabIndex = 7;
            this.btn_filtraOperePerTipologia.Text = "Filtra opere per tipologia";
            this.btn_filtraOperePerTipologia.UseVisualStyleBackColor = true;
            this.btn_filtraOperePerTipologia.Click += new System.EventHandler(this.btn_filtraOperePerTipologia_Click);
            // 
            // btn_filtraPerPeriodoStorico
            // 
            this.btn_filtraPerPeriodoStorico.Location = new System.Drawing.Point(0, 69);
            this.btn_filtraPerPeriodoStorico.Name = "btn_filtraPerPeriodoStorico";
            this.btn_filtraPerPeriodoStorico.Size = new System.Drawing.Size(194, 43);
            this.btn_filtraPerPeriodoStorico.TabIndex = 8;
            this.btn_filtraPerPeriodoStorico.Text = "Filtra per periodo storico";
            this.btn_filtraPerPeriodoStorico.UseVisualStyleBackColor = true;
            this.btn_filtraPerPeriodoStorico.Click += new System.EventHandler(this.btn_filtraPerPeriodoStorico_Click);
            // 
            // btn_filtraPerMuseo
            // 
            this.btn_filtraPerMuseo.Location = new System.Drawing.Point(2, 127);
            this.btn_filtraPerMuseo.Name = "btn_filtraPerMuseo";
            this.btn_filtraPerMuseo.Size = new System.Drawing.Size(194, 43);
            this.btn_filtraPerMuseo.TabIndex = 9;
            this.btn_filtraPerMuseo.Text = "Filtra per museo";
            this.btn_filtraPerMuseo.UseVisualStyleBackColor = true;
            this.btn_filtraPerMuseo.Click += new System.EventHandler(this.btn_filtraPerMuseo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 431);
            this.Controls.Add(this.pnl_bottoni);
            this.Controls.Add(this.btn_cercaOperaPerTitolo);
            this.Controls.Add(this.btn_cercaOperaPerAutore);
            this.Controls.Add(this.btn_cercaOperaPerID);
            this.Controls.Add(this.btn_filtri);
            this.Controls.Add(this.btn_ricerche);
            this.Controls.Add(this.grigliaOpere);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btn_cercaOperaPerTitolo;
        private System.Windows.Forms.Panel pnl_bottoni;
        private System.Windows.Forms.Button btn_filtraPerMuseo;
        private System.Windows.Forms.Button btn_filtraPerPeriodoStorico;
        private System.Windows.Forms.Button btn_filtraOperePerTipologia;
    }
}

