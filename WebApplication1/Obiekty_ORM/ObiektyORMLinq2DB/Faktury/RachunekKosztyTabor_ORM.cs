using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Faktury
{
    [Table(Name = "RACH_KOSZTY_TABOR")]
    public class RachunekKosztyTabor_ORM
    {
        [PrimaryKey]
        [Column("ID_RACH"), NotNull]
        public int ID_RACH { get; set; }

        [Column("NR_KOLEJNY")]
        public int? NR_KOLEJNY { get; set; }

        [Column("NR_RACH"), Nullable]
        public string NR_RACH { get; set; }

        [Column("DATA")]
        public DateTime? DATA { get; set; }

        [Column("ID_POJAZDU")]
        public int? ID_POJAZDU { get; set; }

        [Column("KM_LADOWNE")]
        public int? KM_LADOWNE { get; set; }

        [Column("KM_PUSTE")]
        public int? KM_PUSTE { get; set; }

        [Column("TRASA"), Nullable]
        public string TRASA { get; set; }

        [Column("ILOSC_DNI")]
        public int? ILOSC_DNI { get; set; }

        [Column("ID_NACZEPY")]
        public int? ID_NACZEPY { get; set; }

        [Column("LICZNIK")]
        public int? LICZNIK { get; set; }

        [Column("UWAGI"), Nullable]
        public string UWAGI { get; set; }

        [Column("DATA_SPRZEDAZY")]
        public DateTime? DATA_SPRZEDAZY { get; set; }

        [Column("DATA_OTRZYMANIA")]
        public DateTime? DATA_OTRZYMANIA { get; set; }

        [Column("ID_KONTRAHENT")]
        public int? ID_KONTRAHENT { get; set; }

        [Column("KONTRAHENT"), Nullable]
        public string KONTRAHENT { get; set; }

        [Column("RACHUNEK"), Nullable]
        public string RACHUNEK { get; set; }

        [Column("DATA_PLATNOSCI")]
        public DateTime? DATA_PLATNOSCI { get; set; }

        [Column("REJESTR"), NotNull]
        public int REJESTR { get; set; } = 0;            // id rejestr dla kosztów to rodek trwały 

        [Column("DATA_KSIEGOWA")]
        public DateTime? DATA_KSIEGOWA { get; set; }

        [Column("ZAPLACONA")]
        public int? ZAPLACONA { get; set; }   // 0 - niezapłącona  , 1 - niedopłata ,  2 - zapłacona całkowicie, 3 - nadpłata

        [Column("DATA_ZAPLATY")]
        public DateTime? DATA_ZAPLATY { get; set; }

        [Column("ZAPLACONA_BRUTTO")]
        public double? ZAPLACONA_BRUTTO { get; set; }   // brutto lub netto w PLN

        [Column("ID_KONTA")]
        public int? ID_KONTA { get; set; }

        [Column("IDZLECENIA")]
        public int? IDZLECENIA { get; set; }

        [Column("BRUTTO")]
        public double? BRUTTO { get; set; }

        [Column("NETTO")]
        public double? NETTO { get; set; }

        [Column("VAT")]
        public double? VAT { get; set; }

        [Column("NETTO_WALUTA")]
        public double? NETTO_WALUTA { get; set; }

        [Column("BRUTTO_WALUTA")]
        public double? BRUTTO_WALUTA { get; set; }

        [Column("ID_WALUTA")]
        public int? ID_WALUTA { get; set; }

        [Column("ID_VAT")]
        public int? ID_VAT { get; set; }

        [Column("ID_TABELA")]
        public int? ID_TABELA { get; set; }

        [Column("VAT_W_PLN")]
        public double? VAT_W_PLN { get; set; }  // vat w pln oplacony

        [Column("VAT_W_WAL")]
        public double? VAT_W_WAL { get; set; }   //  vat w waluce

        [Column("VAT_ZAPLACONO")]
        public int? VAT_ZAPLACONO { get; set; }  // 0 - niezapłacona   ,   1 - niedopłata,  2 - zapłacona całkoicie , 3 - nadpłata

        [Column("VAT_DATA")]
        public DateTime? VAT_DATA { get; set; }

        [Column("UWAGI1"), Nullable]
        public string UWAGI1 { get; set; }

        [Column("UWAGI2"), Nullable]
        public string UWAGI2 { get; set; }

        [Column("KOMPESATA"), NotNull]
        public int KOMPESATA { get; set; } = 0;

        [Column("PRZESLANA"), NotNull]
        public int PRZESLANA { get; set; } = 0;

        [Column("WALUTA_ZAPLACONA")]
        public double? WALUTA_ZAPLACONA { get; set; }   //   zapłacona netto lub brutto w walucie  

        [Column("IDVATPLN")]
        public int? IDVATPLN { get; set; }  // 1 - W PLN ;  2 - W Walucie ;  3- W Walucie Vat PLN ;   4 - Import Uslug ;  5 -  Poza UE 

        [Column("KURS")]
        public double? KURS { get; set; }

        [Column("UPUST")]
        public double? UPUST { get; set; }

        [Column("IDKASA")]
        public int? IDKASA { get; set; }

        [Column("IDRAP")]
        public int? IDRAP { get; set; }

        [Column("LINK_FAKTURA")]
        public int? LINK_FAKTURA { get; set; }

        // --------------------------------------

        [Column("ID_SPOSOB_PL")]
        public int? ID_SPOSOB_PL { get; set; }  //  ----->   id konta bankowego nr 2

        // --------------------------------------


        [Column("IDKOSZTY_STAWKA")]
        public int? IDKOSZTY_STAWKA { get; set; }

        [Column("IDTOWARY")]
        public int? IDTOWARY { get; set; }

        [Column("IDDZIAL")]
        public int? IDDZIAL { get; set; }

        [Column("IDFAKTURY")]
        public int? IDFAKTURY { get; set; }

        [Column("KURSALIOR")]
        public double? KURSALIOR { get; set; }

        [Column("IDFIRMA"), NotNull]
        public int IDFIRMA { get; set; } = 1;

        [Column("POSREDNI")]
        public int? POSREDNI { get; set; }


        // uwaga to jest flaga 0 - 1 zatwierdzona z KSeF do normalngo rejestru

        [Column("IDSRODKA")]
        public int? IDSRODKA { get; set; }



        [Column("IDKOSZTU")]
        public int? IDKOSZTU { get; set; }

        [Column("IDUSER")]
        public int? IDUSER { get; set; }

        [Column("VATZAPL")]
        public double? VATZAPL { get; set; }

        [Column("ZAMKNIETE")]
        public int? ZAMKNIETE { get; set; }

        [Column("ZAMKNIETA")]
        public int? ZAMKNIETA { get; set; }

        [Column("IDPRZELEW")]
        public int? IDPRZELEW { get; set; }

        [Column("PLATNEID")]
        public int? PLATNEID { get; set; }

        [Column("PODSTAWA_CLO_EUR")]
        public double? PODSTAWA_CLO_EUR { get; set; }

        [Column("NUMER_CLO"), Nullable]
        public string NUMER_CLO { get; set; }

        [Column("PROCENT_CLO")]
        public double? PROCENT_CLO { get; set; }

        [Column("WART_CLO")]
        public double? WART_CLO { get; set; }

        [Column("RODZAJ_DOKUMENTU")]
        public int? RODZAJ_DOKUMENTU { get; set; }

        [Column("PODSTAWA_CLO")]
        public double? PODSTAWA_CLO { get; set; }
    }
}

