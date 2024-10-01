using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;
using Newtonsoft.Json.Linq;


namespace OpereDarteConservateNeiMuseiInLombardia
{
    internal class Catalogo
    {
        public List<Opera> opere;

        public void LeggiJSON()
        {
            List<Opera> opere = new List<Opera>();

            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nelle lettura del file JSON: " + ex);
            }

        }
    }
}
