using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.ObiektyORMLinq2DB.TS.Kierowcy
{

    [Table(Name = "NACZEPY")]
    public class NACZEPY_ORM
    {
    [PrimaryKey, Identity]
    [Column(Name = "ID_NACZEPY")]
    public int ID_NACZEPY { get; set; }
    [Column(Name = "ID_GATUNKU_NACZ")]
     public int? ID_GATUNKU_NACZ { get; set; }
    [Column(Name = "NR_REJ")]
    public string NR_REJ { get; set; }
    [Column(Name = "DOWOD_REJ")]
    public string DOWOD_REJ { get; set; }
    [Column(Name = "NR_EWID")]
    public string NR_EWID { get; set; }
    [Column(Name = "PRZEZNACZENIE")]
    public string PRZEZNACZENIE { get; set; }
    [Column(Name = "NR_PODWOZIA")]
     public string NR_PODWOZIA { get; set; }
     [Column(Name = "TYP")]
     public string TYP { get; set; }
     [Column(Name = "OPONY")]
     public string OPONY { get; set; }
     [Column(Name = "OPIS_ZACZEPOW")]
     public string OPIS_ZACZEPOW { get; set; }        
     [Column(Name = "ROK_PROD")]
     public int ROK_PROD {  get; set; }        
     [Column(Name = "ID_MARKA")]
     public int? ID_MARKA { get; set; }            
     [Column(Name = "ID_RODZAJ")]
     public int? ID_RODZAJ { get; set; }
     [Column(Name = "MASA")]
      public int MASA { get; set; }
      [Column(Name = "DLUGOSC")]
      public double DLUGOSC { get; set; }
      [Column(Name = "SZEROKOSC")]
      public double SZEROKOSC { get; set; }

        [Column(Name = "WYSOKOSC")]
        public double WYSOKOSC { get; set; }

        [Column(Name = "LADOWNOSC")]
        public int LADOWNOSC { get; set; }
        [Column(Name = "IL_OSI")]
        public int IL_OSI { get; set; }

        [Column(Name = "AGREGAT")]
        public int? AGREGAT { get; set; }

        [Column(Name = "AGREGAT_ZBIORN")]
        public int? AGREGAT_ZBIORN { get; set; }


        [Column(Name = "KOMORA1")]
        public int KOMORA1 { get; set; }

        [Column(Name = "KOMORA2")]
        public int KOMORA2 { get; set; }

        [Column(Name = "KOMORA3")]
        public int KOMORA3 { get; set; }

        [Column(Name = "KOMORA4")]
        public int KOMORA4 { get; set; }

        [Column(Name = "KOMORA5")]
        public int KOMORA5 { get; set; }

        [Column(Name = "KOMORA6")]
        public int KOMORA6 { get; set; }

        [Column(Name = "KOMORA7")]
        public int KOMORA7 { get; set; }

        [Column(Name = "DEF_KONTENER")]
        public int DEF_KONTENER { get; set; }

        [Column(Name = "DEF_KONTENER1")]
        public int DEF_KONTENER1 { get; set; }

        [Column(Name = "OGRZEWANIE")]
        public int? OGRZEWANIE { get; set; }

        [Column(Name = "OPIS")]
        public string OPIS { get; set; }

        [Column(Name = "KONTO1")]
        public string KONTO1 { get; set; }
        [Column(Name = "KONTO2")]
        public string KONTO2 { get; set; }
        [Column(Name = "KONTO3")]
        public string KONTO3 { get; set; }
        [Column(Name = "KONTO4")]
        public string KONTO4 { get; set; }
        [Column(Name = "NIEAKTYWNY")]
        public int NIEAKTYWNY { get; set; }
        [Column(Name = "RATA")]
        public double RATA { get; set; }
        [Column(Name = "PT")]
        public DateTime PT { get; set; }
        [Column(Name = "AC")]
        public DateTime AC { get; set; }
        [Column(Name = "OC")]
        public DateTime OC { get; set; }
        [Column(Name = "DATA_ZAKUPU")]
        public DateTime DATA_ZAKUPU { get; set; }
        [Column(Name = "DATA_WYKUPU")]
        public DateTime DATA_WYKUPU { get; set; }
        [Column(Name = "DATA_SPRZEDAZY")]
        public DateTime DATA_SPRZEDAZY { get; set; }
        [Column(Name = "DATA_LIKWIDACJI")]
        public DateTime DATA_LIKWIDACJI { get; set; }
        [Column(Name = "IDWALUTY")]
        public int? IDWALUTY { get; set; }

        
    }
}
