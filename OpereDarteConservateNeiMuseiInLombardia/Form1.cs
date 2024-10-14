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

namespace OpereDarteConservateNeiMuseiInLombardia
{
    public partial class Form1 : Form
    {
        Catalogo catalogo = new Catalogo();

        public Form1()
        {
            InitializeComponent();          
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            catalogo.LeggiFile();
            grigliaOpere.DataSource = catalogo.opere;
            //grigliaOpere.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //grigliaOpere.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grigliaOpere.ReadOnly = true;
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

        private void btn_cercaOperaPerTitolo_Click(object sender, EventArgs e)
        {

        }

        private void btn_cercaOperaPerAutore_Click(object sender, EventArgs e)
        {

        }

        private void btn_cercaOperaPerID_Click(object sender, EventArgs e)
        {
            catalogo.CercaOperaPerID();
        }

        private void btn_filtraOperePerTipologia_Click(object sender, EventArgs e)
        {

        }

        private void btn_filtraPerPeriodoStorico_Click(object sender, EventArgs e)
        {

        }

        private void btn_filtraPerMuseo_Click(object sender, EventArgs e)
        {

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
    }
}
