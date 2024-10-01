using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace OpereDarteConservateNeiMuseiInLombardia
{
    internal class Opera    
    {
        // IDK: Identificativo unico dell'opera
        private string IDK;

        // ESC: Ente o museo che ospita l'opera
        private string ESC;

        // GRP: Gruppo di opere d'arte (categoria)
        private string GRP;

        // OGTD: Tipo di opera (es. dipinto, scultura)
        private string OGTD;

        // SGTI: Soggetto dell'opera
        private string SGTI;

        // PVCS: Paese di origine
        private string PVCS;

        // PVCP: Provincia di origine
        private string PVCP;

        // PVCN: Comune di origine
        private string PVCN;

        // PVCC: Luogo specifico di origine (località)
        private string PVCC;

        // LDCT: Tipo di edificio dove si trova l'opera
        private string LDCT;

        // LDCQ: Tipo di ente o ente pubblico
        private string LDCQ;

        // LDCN: Nome dell'edificio o del luogo
        private string LDCN;

        // LDCU: Indirizzo dell'edificio
        private string LDCU;

        // LDCM: Nome del museo o dell'ente che ospita l'opera
        private string LDCM;

        // COLD: Condizioni di conservazione dell'opera
        private string COLD;

        // DTZG: Datazione dell'opera (secolo)
        private string DTZG;

        // DTZS: Datazione dell'opera (specifica)
        private string DTZS;

        // DTSI: Anno di creazione dell'opera
        private int DTSI;

        // AUTN: Nome dell'autore dell'opera
        private string AUTN;

        // AUTA: Note sull'autore o sull'opera
        private string AUTA;

        // ATBD: Categoria o tipo di arte
        private string ATBD;

        // MTC: Materiale utilizzato per l'opera
        private string MTC;

        // DESO: Descrizione dell'opera
        private string DESO;

        // NSC: Note sullo stato di conservazione
        private string NSC;

        // STCC: Stato di conservazione
        private string STCC;

        // CDGG: Proprietà dell'opera
        private string CDGG;

        // FUR: Nome del fornitore o dell'artista
        private string FUR;

        // GPDPX: Coordinate X della posizione
        private double GPDPX;

        // GPDPY: Coordinate Y della posizione
        private double GPDPY;

        // location: Coordinate geografiche (latitudine, longitudine)
        private (double Latitude, double Longitude) location;

        // URL: Link per accedere a ulteriori informazioni sull'opera
        private string URL;

        // Proprietà 
        public string Idk
        {
            get { return IDK; }
            set { IDK = value; }
        }

        public string Esc
        {
            get { return ESC; }
            set { ESC = value; }
        }

        public string Grp
        {
            get { return GRP; }
            set { GRP = value; }
        }

        public string Ogtd
        {
            get { return OGTD; }
            set { OGTD = value; }
        }

        public string Sgti
        {
            get { return SGTI; }
            set { SGTI = value; }
        }

        public string Pvcs
        {
            get { return PVCS; }
            set { PVCS = value; }
        }

        public string Pvcp
        {
            get { return PVCP; }
            set { PVCP = value; }
        }

        public string Pvcn
        {
            get { return PVCN; }
            set { PVCN = value; }
        }

        public string Pvcc
        {
            get { return PVCC; }
            set { PVCC = value; }
        }

        public string Ldct
        {
            get { return LDCT; }
            set { LDCT = value; }
        }

        public string Ldcq
        {
            get { return LDCQ; }
            set { LDCQ = value; }
        }

        public string Ldcn
        {
            get { return LDCN; }
            set { LDCN = value; }
        }

        public string Ldcu
        {
            get { return LDCU; }
            set { LDCU = value; }
        }

        public string Ldcm
        {
            get { return LDCM; }
            set { LDCM = value; }
        }

        public string Cold
        {
            get { return COLD; }
            set { COLD = value; }
        }

        public string Dtzg
        {
            get { return DTZG; }
            set { DTZG = value; }
        }

        public string Dtzs
        {
            get { return DTZS; }
            set { DTZS = value; }
        }

        public int Dtsi
        {
            get { return DTSI; }
            set { DTSI = value; }
        }

        public string Autn
        {
            get { return AUTN; }
            set { AUTN = value; }
        }

        public string Auta
        {
            get { return AUTA; }
            set { AUTA = value; }
        }

        public string Atbd
        {
            get { return ATBD; }
            set { ATBD = value; }
        }

        public string Mtc
        {
            get { return MTC; }
            set { MTC = value; }
        }

        public string Deso
        {
            get { return DESO; }
            set { DESO = value; }
        }

        public string Nsc
        {
            get { return NSC; }
            set { NSC = value; }
        }

        public string Stcc
        {
            get { return STCC; }
            set { STCC = value; }
        }

        public string Cdgg
        {
            get { return CDGG; }
            set { CDGG = value; }
        }

        public string Fur
        {
            get { return FUR; }
            set { FUR = value; }
        }

        public double GpdpX
        {
            get { return GPDPX; }
            set { GPDPX = value; }
        }

        public double GpdpY
        {
            get { return GPDPY; }
            set { GPDPY = value; }
        }

        public (double Latitude, double Longitude) Location
        {
            get { return location; }
            set { location = value; }
        }

        public string Url
        {
            get { return URL; }
            set { URL = value; }
        }
    }
}
