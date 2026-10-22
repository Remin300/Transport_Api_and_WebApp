using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Faktury.Views
{
    [Table(Name = "V_RACHP_KOSZTY_TABOR_NEW")]
    public class VRachP_Koszty_Tabor_New_ORM
    {

        [Column("ID_RACH")] // PK
        public int ID_RACH { get; set; }

        //[Column("IDSRODKA")] // Uwaga to flaga 0 1  dla statusu zatwierdzenia z modułu KSeF
        //public int IDSRODKA { get; set; }


        [Column("ZAPLACONA")]
        public int ZAPLACONA { get; set; }     //  0 niezaplacona   ;   1 niedoplata   ;   2 zaplacona  ;  3 nadplata 

        [Column("RACHUNEK"), Nullable]
        public string RACHUNEK { get; set; }

        [Column("KNT"), Nullable]
        public string KNT { get; set; }

        [Column("KNT1"), Nullable]
        public string KNT1 { get; set; }

        [Column("ILOSC_DNI")]
        public int? ILOSC_DNI { get; set; }

        [Column("TERMIN_PLATNOSCI")]
        public DateTime TERMIN_PLATNOSCI { get; set; }

        [Column("ID_KONTRAHENTA")]
        public int ID_KONTRAHENTA { get; set; }

        [Column("KONTRAHENT_SKROT"), Nullable]
        public string KONTRAHENT_SKROT { get; set; }

        [Column("NIP"), Nullable]
        public string NIP { get; set; }


        [Column("NUMER_PELNY"), Nullable]
        public string NUMER_PELNY { get; set; }

        [Column("OT"), Nullable]
        public string OT { get; set; }

        [Column("KURS")]
        public double KURS { get; set; }

        [Column("ID_WALUTY")]
        public int ID_WALUTY { get; set; }

        [Column("WALUTA")]
        public string WALUTA { get; set; }


        [Column("BRUTTO_PLN")] public double BRUTTO_PLN { get; set; }
        [Column("NETTO_PLN")] public double NETTO_PLN { get; set; }
        [Column("VAT_W_PLN")] public double VAT_W_PLN { get; set; }

        [Column("BRUTTO_WALUTA")] public double BRUTTO_WALUTA { get; set; }
        [Column("NETTO_WALUTA")] public double NETTO_WALUTA { get; set; }
        [Column("VAT_WALUTA")] public double VAT_WALUTA { get; set; }



        [Column("DATA_WYSTAWIENIA")]
        public DateTime? DATA_WYSTAWIENIA { get; set; }

        [Column("DATA_SPRZEDAZY")]
        public DateTime? DATA_SPRZEDAZY { get; set; }

        [Column("DATA_PLATNOSCI")]
        public DateTime? DATA_PLATNOSCI { get; set; }

        [Column("DATA_KSIEGOWA")]
        public DateTime? DATA_KSIEGOWA { get; set; }

        [Column("RODZAJ_FAKTURY")]
        public int RODZAJ_FAKTURY { get; set; }

        [Column("IDVATPLN")]
        public int IDVATPLN { get; set; }



        [Column("VAT_ZAPLACONO")]
        public int VAT_ZAPLACONO { get; set; }

        [Column("ZAPLACONA_BRUTTO")]
        public double ZAPLACONA_BRUTTO { get; set; }

        [Column("REJESTR")]
        public int REJESTR { get; set; }




    }
}
