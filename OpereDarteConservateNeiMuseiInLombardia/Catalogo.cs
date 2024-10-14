using System;
using System.Collections.Generic;
using System.IO;
using ExcelDataReader;
using System.Windows.Forms;
using System.Data;
using System.Text;
using Microsoft.VisualBasic;


namespace OpereDarteConservateNeiMuseiInLombardia
{
    internal class Catalogo
    {
        public List<Opera> opere = new List<Opera>();
            
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

        public void CercaOperaPerID()
        {
            string id = Interaction.InputBox("Inserisci l'opera", "Inserimento opera", "");
            int risultato = Ricerca(id);

            if (risultato != -1)
            {
                MessageBox.Show("Opera trovata all'indice: " + risultato);
            }
            else
            {
                MessageBox.Show("Opera non trovata.");
            }
        }
        public void CercaOperaPerTitolo()
        { }
        public void CercaOperaPerAutore()
        { }
        public void FiltraPerTipologia()
        { }
        public void FiltraPerPeriodoStorico()
        { }
        public void FiltraPerMuseo()
        { }


        public int Ricerca(string id)
        {
            int i;

            for(i = 0; i < opere.Count; i++)
            {
                if (opere[i].Idk == id)
                {
                    return i;
                }
            }

            return -1;  

        }

        // Ricerca dicotomica
        public int RicercaDicotomica(string opera)
        {
            int inizio = 0;
            int fine = opere.Count - 1;

            while (inizio <= fine)
            {
                // Calcolo dell'indice di metà
                int medio = (inizio + fine) / 2;

                // Confronto tra la stringa al centro e il target
                int confronto = string.Compare(opere[medio].Idk, opera);

                if (confronto == 0)
                {
                    return medio; // Stringa trovata
                }
                else if (confronto < 0)
                {
                    inizio = medio + 1; // Ignora la parte sinistra
                }
                else
                {
                    fine = medio - 1; // Ignora la parte destra
                }
            }

            return -1; // Elemento non trovato
        }
    }
}
