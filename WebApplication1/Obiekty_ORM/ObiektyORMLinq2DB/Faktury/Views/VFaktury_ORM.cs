using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Faktury.Views
{
    [Table(Name = "VFAKTURYNEW")]
    public class VFaktury_ORM
    {
        [Column(Name = "ID_FAKTURY"), PrimaryKey]
        public int ID_FAKTURY { get; set; }

        [Column(Name = "NUMERFAKTURY"),]
        public string NumerFaktury { get; set; }

        [Column(Name = "RODZAJ_FAKTURY"),]
        public int RODZAJ_FAKTURY { get; set; }

        [Column(Name = "RODZAJ_DOKUMENTU"),]
        public int RODZAJ_DOKUMENTU { get; set; }

        [Column(Name = "ID_REJESTR"),]
        public int ID_REJESTR { get; set; }

        [Column(Name = "ZAPLACONA"),]
        public int ZAPLACONA { get; set; }

        [Column(Name = "ID_KONTRAHENTA"),]
        public int ID_KONTRAHENTA { get; set; }

        [Column(Name = "KONTRAHENT")]
        public string Kontrahent { get; set; }

        [Column(Name = "DATA_WYSTAWIENIA")]
        public DateTime DataWystawienia { get; set; }

        [Column(Name = "DATA_SPRZEDAZY")]
        public DateTime DataSprzedazy { get; set; }

        [Column(Name = "DATA_ZAPLATY")]
        public DateTime? DATA_ZAPLATY { get; set; }

        [Column(Name = "WARTOSC_NETTO_WALUTA")]
        public double WartoscNettoWaluta { get; set; }

        [Column(Name = "WARTOSC_BRUTTO_WALUTA")]
        public double WartoscBruttoWaluta { get; set; }

        [Column(Name = "WARTOSC_PODATKU_WALUTA")]
        public double WartoscPodatkuWaluta { get; set; }

        [Column(Name = "WARTOSC_NETTO_PLN")]
        public double WartoscNettoPLN { get; set; }

        [Column(Name = "WARTOSC_BRUTTO_PLN")]
        public double WartoscBruttoPLN { get; set; }

        [Column(Name = "WARTOSC_PODATKU_PLN")]
        public double WartoscPodatkuPLN { get; set; }

        [Column(Name = "ZAPLACONO_PLN")]
        public double ZAPLACONO_PLN { get; set; }

        [Column(Name = "ZAPLACONO_EUR")]
        public double ZAPLACONO_EUR { get; set; }

        [Column(Name = "WALUTA")]
        public string Waluta { get; set; }

        [Column(Name = "STATUS")]
        public string Status { get; set; }

        [Column(Name = "TERMINPLATNOSCI")]
        public DateTime TerminPlatnosci { get; set; }

        [Column(Name = "PRZETERMINOWANA")]
        public int Przeterminowana { get; set; }

        [Column(Name = "WYSTAWILNAZWISKO")]
        public string WYSTAWILNAZWISKO { get; set; }

        [Column(Name = "WYSTAWILIMIE")]
        public string WYSTAWILIMIE { get; set; }

        [Column(Name = "KATEGORIAZLECENIA")]
        public string KATEGORIAZLECENIA { get; set; }

        [Column(Name = "KONTOBANKOWE")]
        public string KONTOBANKOWE { get; set; }

        [Column(Name = "ZATWIERDZONA")]
        public string ZATWIERDZONA { get; set; }

        [Column(Name = "WYSLANA_DO_KSEF")]
        public string WYSLANA_DO_KSEF { get; set; }

        [Column(Name = "NUMER_ZLECENIA")]
        public string NUMER_ZLECENIA { get; set; }

        [Column(Name = "TRANSAKCJE")]
        public int TRANSAKCJE { get; set; }

        [Column(Name = "IDDZIAL")]
        public int IDDZIAL { get; set; }

        [Column(Name = "VATWPLN")]
        public int VATWPLN { get; set; }

        [Column(Name = "IDSPEDYTOR")]
        public int IDSPEDYTOR { get; set; }
        [Column(Name = "IDWYSTAWIL")]
        public int IDWYSTAWIL { get; set; }
        [Column(Name = "SPEDYTORLOGIN")]
        public string SPEDYTORLOGIN { get; set; }
        [Column(Name = "DZIAL")]
        public string DZIAL { get; set; }
        [Column(Name = "DZIAL_BURIAN")]
        public string DZIAL_BURIAN { get; set; }

        [Column(Name = "OPIS_POZYCJI")]
        public string OPIS_POZYCJI { get; set; } // w bazie inne pole przeslana_xml dotyczy faktoringu

        [Column(Name = "NIP")]
        public string NIP { get; set; }
        [Column(Name = "UWAGI")]
        public string UWAGI { get; set; }

        [Column(Name = "UWAGI2")] // DODATKOWY OPIS DO FAKTURY - STOPKA
        public string UWAGI2 { get; set; }
        [Column(Name = "UWAGI3")] // DODATKOWY OPIS DO FAKTURY - STOPKA
        public string UWAGI3 { get; set; }

        [Column(Name = "TT_D")] // kurs waluty na fakturze
        public int TT_D { get; set; }
        [Column(Name = "ILOSC_DNI_PLATN")] //
        public int ILOSC_DNI_PLATN { get; set; }

        [Column(Name = "ADRES")] 
        public string ADRES { get; set; }

        [Column(Name = "MIEJSCOWOSC")]
        public string MIEJSCOWOSC { get; set; }
        [Column(Name = "NR_KOLEJNY")]
        public int NR_KOLEJNY { get; set; }
        [Column(Name = "ID_WALUTY")] 
        public int ID_WALUTY { get; set; }
        [Column(Name = "ID_KRAJU")]
        public int ID_KRAJU { get; set; }
        [Column(Name = "VAT")] 
        public string VAT { get; set; }

        [Column(Name = "GTU")] 
        public string GTU { get; set; }


        
    }
}
