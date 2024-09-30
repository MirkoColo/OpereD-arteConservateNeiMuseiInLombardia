using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpereDarteConservateNeiMuseiInLombardia
{
    internal class Opera
    {
        // Codice identificativo dell'opera
        private string _idk;

        // Numero di catalogo dell'opera
        private int _nctr;

        // Numero di catalogo nella tipologia (specifico per l'opera)
        private string _nctn;

        // Entità/sede conservativa (museo o collezione in cui l'opera è conservata)
        private string _esc;

        // Gruppo di appartenenza dell'opera (tipologia come "pittura", "scultura", etc.)
        private string _grp;

        // Oggetto o descrizione dell'opera (ad esempio "dipinto", "scultura")
        private string _ogtd;

        // Quantità, se l'opera fa parte di un insieme
        private float? _qntn;

        // Varie caratteristiche dell'opera (es. soggetto, stile, tecnica)
        private string _sgtc;
        private string _sgti;
        private string _sgtt;

        // Dettagli sui provvedimenti di catalogazione o conservazione
        private string _pvcs;
        private string _pvcr;
        private string _pvcp;

        // Proprietà pubbliche per accedere ai campi privati
        public string IDK
        {
            get { return _idk; }
            set { _idk = value; }
        }

        public int NCTR
        {
            get { return _nctr; }
            set { _nctr = value; }
        }

        public string NCTN
        {
            get { return _nctn; }
            set { _nctn = value; }
        }

        public string ESC
        {
            get { return _esc; }
            set { _esc = value; }
        }

        public string GRP
        {
            get { return _grp; }
            set { _grp = value; }
        }

        public string OGTD
        {
            get { return _ogtd; }
            set { _ogtd = value; }
        }

        public float? QNTN
        {
            get { return _qntn; }
            set { _qntn = value; }
        }

        public string SGTC
        {
            get { return _sgtc; }
            set { _sgtc = value; }
        }

        public string SGTI
        {
            get { return _sgti; }
            set { _sgti = value; }
        }

        public string SGTT
        {
            get { return _sgtt; }
            set { _sgtt = value; }
        }

        public string PVCS
        {
            get { return _pvcs; }
            set { _pvcs = value; }
        }

        public string PVCR
        {
            get { return _pvcr; }
            set { _pvcr = value; }
        }

        public string PVCP
        {
            get { return _pvcp; }
            set { _pvcp = value; }
        }
    }
}
