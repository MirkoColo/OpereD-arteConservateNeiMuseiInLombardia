using System;
using System.Collections.Generic;
using System.IO;
using ExcelDataReader;
using System.Windows.Forms;
using System.Data;
using System.Text;
using Microsoft.VisualBasic;
using System.Security.Policy;
using GMap.NET;

namespace OpereDarteConservateNeiMuseiInLombardia
{
    internal class Catalogo
    {
        public List<Opera> opere = new List<Opera>();

        private Form _form;  // Riferimento alla form principale
        public Catalogo(Form Form)
        {
            _form = Form;  // Assegna il riferimento della form
        }
        public void LeggiFile()
        {
            try
            {
                using (StreamReader reader = new StreamReader(@"catalogo.csv", Encoding.UTF8))
                {
                    string[] headers = reader.ReadLine()?.Split(';'); // Legge l'intestazione

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine()?.Trim(); // Rimuovi spazi

                        string[] values = line.Split(';');

                        if (values.Length == headers.Length)
                        {
                            Opera opera = new Opera
                            {
                                Idk = values[0],
                                Esc = !string.IsNullOrEmpty(values[1]) ? values[1] : null,
                                Grp = !string.IsNullOrEmpty(values[2]) ? values[2] : null,
                                Ogtd = !string.IsNullOrEmpty(values[3]) ? values[3] : null,
                                Sgti = !string.IsNullOrEmpty(values[4]) ? values[4] : null,
                                Pvcp = !string.IsNullOrEmpty(values[5]) ? values[5] : null,
                                Pvcn = !string.IsNullOrEmpty(values[6]) ? values[6] : null,
                                Pvcc = !string.IsNullOrEmpty(values[7]) ? values[7] : null,
                                Ldct = !string.IsNullOrEmpty(values[8]) ? values[8] : null,
                                Ldcq = !string.IsNullOrEmpty(values[9]) ? values[9] : null,
                                Ldcn = !string.IsNullOrEmpty(values[10]) ? values[10] : null,
                                Ldcu = !string.IsNullOrEmpty(values[11]) ? values[11] : null,
                                Ldcm = !string.IsNullOrEmpty(values[12]) ? values[12] : null,
                                Cold = !string.IsNullOrEmpty(values[13]) ? values[13] : null,
                                Dtzg = !string.IsNullOrEmpty(values[14]) ? values[14] : null,
                                Dtsi = int.TryParse(values[15]?.Trim(), out int dtsiValue) ? (int)dtsiValue : 0,
                                Autn = !string.IsNullOrEmpty(values[16]) ? values[16] : null,
                                Atbd = !string.IsNullOrEmpty(values[17]) ? values[17] : null,
                                Mtc = !string.IsNullOrEmpty(values[18]) ? values[18] : null,
                                Deso = !string.IsNullOrEmpty(values[19]) ? values[19] : null,
                                Nsc = !string.IsNullOrEmpty(values[20]) ? values[20] : null,
                                Stcc = !string.IsNullOrEmpty(values[21]) ? values[21] : null,
                                Cdgg = !string.IsNullOrEmpty(values[22]) ? values[22] : null,
                                Fur = !string.IsNullOrEmpty(values[23]) ? values[23] : null,
                                GpdpX = double.TryParse(values[24]?.Trim(), out double gpdpXValue) ? (double)gpdpXValue : 0,
                                GpdpY = double.TryParse(values[25]?.Trim(), out double gpdpYValue) ? (double)gpdpYValue : 0,
                                Location = !string.IsNullOrEmpty(values[26]) ? values[26] : null,
                                Url = !string.IsNullOrEmpty(values[27]) ? values[27] : null
                            };

                            opere.Add(opera);
                        }


                    }
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nelle lettura del file: " + ex);
            }

        }

        // RICERCHE
        public int CercaOperaPerID()
        {
            string id = ShowInputBox("Inserisci l'ID dell'opera", "Inserimento ID opera", "");
            int risultato = Ricerca(id, "Idk");

            return risultato;
        }


        public List<Opera> CercaOperaPerDescrizione()
        {
            string descrizione = ShowInputBox("Inserisci la descrizione dell'opera", "Inserimento descrizione opera", "");

            return Ricercas(descrizione, "Deso");
        }

        public List<Opera> CercaOperaPerSoggetto()
        {
            string soggetto = ShowInputBox("Inserisci il soggetto dell'opera", "Inserimento soggetto opera", "");

            return Ricercas(soggetto, "Sgti");
        }

        public int CercaImmagine()
        {
            string opera = ShowInputBox("Inserisci l'ID dell'opera", "Inserimento ID", "");
            int risultato = Ricerca(opera, "Idk");

            return risultato;
        }

        public int CercaMuseo()
        {
            string museo = ShowInputBox("Inserisci il nome del museo", "Inserimento museo", "");
            int risultato = Ricerca(museo, "Ldcm");

            return risultato;
        }
        public int Ricerca(string opera, string sigla)
        {
            int i;
            for (i = 0; i < opere.Count; i++)
            {
                var tipo = opere[i].GetType();  // Ottieni il tipo dell'oggetto
                var proprieta = tipo.GetProperty(sigla);  // Ottieni la proprietà
                var valoreProprieta = proprieta.GetValue(opere[i])?.ToString();  // Ottieni il valore della proprietà come stringa
                if (valoreProprieta == opera)
                {
                    return i;
                }
            }

            return -1;
        }

        public List<Opera> Ricercas(string opera, string sigla)
        { 
            List<Opera> operes = new List<Opera>();
            if (opera.Trim() != "")
            {
                for (int i = 0; i < opere.Count; i++)
                {
                    var tipo = opere[i].GetType();  // Ottieni il tipo dell'oggetto
                    var proprieta = tipo.GetProperty(sigla);  // Ottieni la proprietà
                    var valoreProprieta = proprieta.GetValue(opere[i])?.ToString();  // Ottieni il valore della proprietà come stringa
                    if (valoreProprieta != null && valoreProprieta.Contains(opera))
                    {
                        operes.Add(opere[i]);  // Aggiungi l'indice dell'opera trovata
                    }

                }
                return operes;
            }

            return opere;
        }

        public List<Opera> FiltroDinamico(List<string> values, List<string> checkedItems)
        {
            List<Opera> operes = new List<Opera>();
            List<Opera> opereTemp = new List<Opera>();

            for (int z = 0; z < checkedItems.Count; z++)
            {
                if(z > 0)
                {
                    for (int i = 0; i < operes.Count; i++)
                    {

                        var tipo = operes[i].GetType();  // Ottieni il tipo dell'oggetto
                        var proprieta = tipo.GetProperty(checkedItems[z]);  // Ottieni la proprietà
                        var valoreProprieta = proprieta.GetValue(operes[i])?.ToString();  // Ottieni il valore della proprietà come stringa
                        if (valoreProprieta != null && valoreProprieta.Contains(values[z]))
                        {
                            opereTemp.Add(operes[i]);
                        }
                    }
                    if(opereTemp.Count > 0)
                    {
                        operes.Clear();
                        operes.AddRange(opereTemp);
                        opereTemp.Clear();
                    }

                }
                else
                {
                    for (int i = 0; i < opere.Count; i++)
                    {
                        var tipo = opere[i].GetType();  // Ottieni il tipo dell'oggetto
                        var proprieta = tipo.GetProperty(checkedItems[z]);  // Ottieni la proprietà
                        var valoreProprieta = proprieta.GetValue(opere[i])?.ToString();  // Ottieni il valore della proprietà come stringa
                        if (valoreProprieta != null && valoreProprieta.Contains(values[z]))
                        {
                            operes.Add(opere[i]);
                        }
                    }
                }
                
            }
           

            if (operes.Count == 0)
            {
                MessageBox.Show("Errore durante la filtrazione ");

                return opere;
            }
            else
            {
                return operes;
            }

        }


        public string ShowInputBox(string prompt, string title = "Input", string defaultValue = "")
        {
            // Disabilita temporaneamente TopMost
            bool wasTopMost = _form.TopMost;
            _form.TopMost = false;

            // Mostra l'InputBox e raccoglie l'input dell'utente
            string result = Interaction.InputBox(prompt, title, defaultValue);

            // Ripristina TopMost allo stato precedente
            _form.TopMost = wasTopMost;

            return result;
        }
    }
}
