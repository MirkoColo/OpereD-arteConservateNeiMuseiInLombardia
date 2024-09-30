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

        // Gruppo di appartenenza dell'opera (es. "pittura", "scultura", ecc.)
        private string _grp;

        // Oggetto o descrizione dell'opera (es. "dipinto", "scultura")
        private string _ogtd;

        // Quantità dell'opera, se fa parte di un insieme
        private float? _qntn;

        // Soggetto principale dell'opera
        private string _sgtc;

        // Descrizione iconografica secondaria
        private string _sgti;

        // Tecnica utilizzata nell'opera
        private string _sgtt;

        // Provenienza storica o conservativa (prima sede di conservazione)
        private string _pvcs;

        // Provenienza regionale dell'opera
        private string _pvcr;

        // Provenienza provinciale dell'opera
        private string _pvcp;

        // Provenienza comunale dell'opera
        private string _pvcn;

        // Provenienza specifica (es. museo o collezione privata)
        private string _pvcj;

        // Collezione di appartenenza (es. collezione privata, ente pubblico)
        private string _pvcc;

        // Dettagli conservativi (tipo di restauro)
        private string _ldct;

        // Data del restauro
        private string _ldcq;

        // Nome dell'ultimo conservatore/restauratore
        private string _ldcn;

        // Ulteriori dati sul restauro (luogo o condizioni specifiche)
        private string _ldcu;

        // Materiale utilizzato nella conservazione/restauro
        private string _ldcm;

        // Informazioni sull'inventario/catalogazione
        private string _ldci;

        // Zona geografica di provenienza
        private string _ldcz;

        // Collezione o dipartimento di riferimento
        private string _cold;

        // Data di realizzazione dell'opera (o del restauro)
        private string _dtzg;

        // Anno di produzione dell'opera
        private string _dtzs;

        // Datazione (interpretata o stimata) dell'opera
        private string _dtsi;

        // Descrizione stilistica dell'opera (periodo o movimento artistico)
        private string _dtsv;

        // Fonte della datazione stilistica
        private string _dtsf;

        // Livello di sicurezza della datazione
        private string _dtsl;

        // Nome dell'autore dell'opera
        private string _autn;

        // Biografia dell'autore
        private string _autb;

        // Autenticità dell'opera
        private string _auta;

        // Soggetto principale dell'autore
        private string _auts;

        // Titolo bibliografico dell'opera
        private string _atbd;

        // Riferimenti bibliografici relativi all'opera
        private string _atbr;

        // Materiale costruttivo dell'opera (es. "marmo", "legno")
        private string _mtc;

        // Unità di misura dell'opera (es. cm, metri)
        private string _misu;

        // Altezza dell'opera
        private float? _misa;

        // Lunghezza dell'opera
        private float? _misl;

        // Profondità dell'opera
        private float? _misp;

        // Diametro dell'opera
        private float? _misd;

        // Numero di misure totali
        private int? _misn;

        // Descrizione dettagliata dell'opera
        private string _deso;

        // Numero di serie catalogato
        private string _nsc;

        // Stato di conservazione dell'opera
        private string _stcd;

        // Stato di conservazione catalogato
        private string _stcc;

        // Codice della catalogazione
        private string _cdgg;

        // Data del catalogo
        private string _cmpd;

        // Nome del catalogatore
        private string _cmpn;

        // Edizione del catalogo
        private string _cmpe;

        // Riserva sull'opera
        private string _rsr;

        // Firme dell'autore sull'opera
        private string _fur;

        // Revisione museale
        private string _rvmd;

        // Nome del revisore museale
        private string _rvmn;

        // Eventuali modifiche effettuate durante la revisione museale
        private string _rvme;

        // Data di aggiornamento generale dell'opera
        private string _aggd;

        // Nome della persona che ha aggiornato l'opera
        private string _aggn;

        // Ente o organizzazione che ha effettuato l'aggiornamento
        private string _agge;

        // Fondi ricevuti per l'aggiornamento o restauro dell'opera
        private string _aggf;

        // Coordinate geografiche X (sistema GPDPX)
        private double _gpdpx;

        // Coordinate geografiche Y (sistema GPDPY)
        private double _gpdpy;

        // Coordinate WGS84 X (per la geolocalizzazione)
        private double _wgs84_x;

        // Coordinate WGS84 Y (per la geolocalizzazione)
        private double _wgs84_y;

        // Posizione dell'opera (coordinata WGS84)
        private string _location;

        // URL per visualizzare i dettagli dell'opera online
        private string _url;

        // Proprietà pubbliche

        public string IDK { get => _idk; set => _idk = value; }
        public int NCTR { get => _nctr; set => _nctr = value; }
        public string NCTN { get => _nctn; set => _nctn = value; }
        public string ESC { get => _esc; set => _esc = value; }
        public string GRP { get => _grp; set => _grp = value; }
        public string OGTD { get => _ogtd; set => _ogtd = value; }
        public float? QNTN { get => _qntn; set => _qntn = value; }
        public string SGTC { get => _sgtc; set => _sgtc = value; }
        public string SGTI { get => _sgti; set => _sgti = value; }
        public string SGTT { get => _sgtt; set => _sgtt = value; }
        public string PVCS { get => _pvcs; set => _pvcs = value; }
        public string PVCR { get => _pvcr; set => _pvcr = value; }
        public string PVCP { get => _pvcp; set => _pvcp = value; }
        public string PVCN { get => _pvcn; set => _pvcn = value; }
        public string PVCJ { get => _pvcj; set => _pvcj = value; }
        public string PVCC { get => _pvcc; set => _pvcc = value; }
        public string LDCT { get => _ldct; set => _ldct = value; }
        public string LDCQ { get => _ldcq; set => _ldcq = value; }
        public string LDCN { get => _ldcn; set => _ldcn = value; }
        public string LDCU { get => _ldcu; set => _ldcu = value; }
        public string LDCM { get => _ldcm; set => _ldcm = value; }
        public string LDCI { get => _ldci; set => _ldci = value; }
        public string LDCZ { get => _ldcz; set => _ldcz = value; }
        public string COLD { get => _cold; set => _cold = value; }
        public string DTZG { get => _dtzg; set => _dtzg = value; }
        public string DTZS { get => _dtzs; set => _dtzs = value; }
        public string DTSI { get => _dtsi; set => _dtsi = value; }
        public string DTSV { get => _dtsv; set => _dtsv = value; }
        public string DTSF { get => _dtsf; set => _dtsf = value; }
        public string DTSL { get => _dtsl; set => _dtsl = value; }
        public string AUTN { get => _autn; set => _autn = value; }
        public string AUTB { get => _autb; set => _autb = value; }
        public string AUTA { get => _auta; set => _auta = value; }
        public string AUTS { get => _auts; set => _auts = value; }
        public string ATBD { get => _atbd; set => _atbd = value; }
        public string ATBR { get => _atbr; set => _atbr = value; }
        public string MTC { get => _mtc; set => _mtc = value; }
        public string MISU { get => _misu; set => _misu = value; }
        public float? MISA { get => _misa; set => _misa = value; }
        public float? MISL { get => _misl; set => _misl = value; }
        public float? MISP { get => _misp; set => _misp = value; }
        public float? MISD { get => _misd; set => _misd = value; }
        public int? MISN { get => _misn; set => _misn = value; }
        public string DESO { get => _deso; set => _deso = value; }
        public string NSC { get => _nsc; set => _nsc = value; }
        public string STCD { get => _stcd; set => _stcd = value; }
        public string STCC { get => _stcc; set => _stcc = value; }
        public string CDGG { get => _cdgg; set => _cdgg = value; }
        public string CMPD { get => _cmpd; set => _cmpd = value; }
        public string CMPN { get => _cmpn; set => _cmpn = value; }
        public string CMPE { get => _cmpe; set => _cmpe = value; }
        public string RSR { get => _rsr; set => _rsr = value; }
        public string FUR { get => _fur; set => _fur = value; }
        public string RVMD { get => _rvmd; set => _rvmd = value; }
        public string RVMN { get => _rvmn; set => _rvmn = value; }
        public string RVME { get => _rvme; set => _rvme = value; }
        public string AGGD { get => _aggd; set => _aggd = value; }
        public string AGGN { get => _aggn; set => _aggn = value; }
        public string AGGE { get => _agge; set => _agge = value; }
        public string AGGF { get => _aggf; set => _aggf = value; }
        public double GPDPX { get => _gpdpx; set => _gpdpx = value; }
        public double GPDPY { get => _gpdpy; set => _gpdpy = value; }
        public double WGS84_X { get => _wgs84_x; set => _wgs84_x = value; }
        public double WGS84_Y { get => _wgs84_y; set => _wgs84_y = value; }
        public string LOCATION { get => _location; set => _location = value; }
        public string URL { get => _url; set => _url = value; }
    }
}
