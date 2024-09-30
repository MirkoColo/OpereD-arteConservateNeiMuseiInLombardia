using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpereDarteConservateNeiMuseiInLombardia
{
    public partial class Form1 : Form
    {
        Catalogo catalogo = new Catalogo();

        public Form1()
        {
            InitializeComponent();
            catalogo.Leggi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            catalogo.opere.Add(new Opera());
            grigliaOpere.DataSource = catalogo.opere;
        }
    }
}
