using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Faktury
{
    // uwaga
    //fakturaPozycja.ID_TOWARU = stawkaView.IdTowaru;
    // fakturaPozycja.ID_NAZWA_TOWARU = stawkaView.IdTowaryStawki;                


    [Table(Name = "FAKTURY_POZYCJE")]
    public class Faktury_Pozycje_ORM
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_POZYCJI")]
        public int ID_POZYCJI { get; set; }

        [Column(Name = "ID_FAKTURY"), NotNull]
        public int ID_FAKTURY { get; set; }

        [Column(Name = "TRESC"), Nullable]
        public string TRESC { get; set; }

        [Column(Name = "ILOSC"), NotNull]
        public double ILOSC { get; set; }

        [Column(Name = "JM"), Nullable]
        public string JM { get; set; }

        [Column(Name = "SWWKU"), Nullable]
        public string SWWKU { get; set; }

        [Column(Name = "CENA_NETTO"), NotNull]
        public double CENA_NETTO { get; set; }

        [Column(Name = "ID_VAT"), Nullable]
        public int? ID_VAT { get; set; }

        [Column(Name = "ID_TABELI"), Nullable]
        public int? ID_TABELI { get; set; }

        [Column(Name = "KWOTA_W_WALUCIE"), NotNull]
        public double KWOTA_W_WALUCIE { get; set; }

        [Column(Name = "LINK_NADRZEDNY"), Nullable]
        public int? LINK_NADRZEDNY { get; set; }  // 1 - w korekcie "stan przed" czyi BYŁO

        [Column(Name = "ID_WALUTY"), Nullable]
        public int? ID_WALUTY { get; set; }

        [Column(Name = "RODZAJ_USLUGI"), Nullable]
        public int? RODZAJ_USLUGI { get; set; }

        [Column(Name = "KONTO_WN"), Nullable]
        public string KONTO_WN { get; set; }

        [Column(Name = "KONTO_MA"), Nullable]
        public string KONTO_MA { get; set; }

        [Column(Name = "ZERO_KRAJ"), Nullable]
        public int? ZERO_KRAJ { get; set; }

        [Column(Name = "TRESC_EN"), Nullable]
        public string TRESC_EN { get; set; }

        [Column(Name = "IDOPIS")]
        public int IDOPIS { get; set; } = 0;

        [Column(Name = "DATA_WAZNOSCI"), Nullable]
        public DateTime? DATA_WAZNOSCI { get; set; }

        [Column(Name = "KZ"), Nullable]
        public string KZ { get; set; }

        [Column(Name = "ID_TOWARU"), Nullable]
        public int? ID_TOWARU { get; set; }

        [Column(Name = "SYMBOL"), Nullable]
        public string SYMBOL { get; set; }

        [Column(Name = "WARTOSC_NETTO"), NotNull]
        public double WARTOSC_NETTO { get; set; }

        [Column(Name = "WARTOSC_BRUTTO"), NotNull]
        public double WARTOSC_BRUTTO { get; set; }

        [Column(Name = "WARTOSC_VAT"), NotNull]
        public double WARTOSC_VAT { get; set; }

        [Column(Name = "KOD"), Nullable]
        public string KOD { get; set; }

        [Column(Name = "CENA_DETALICZNA"), NotNull]
        public double CENA_DETALICZNA { get; set; }

        [Column(Name = "UPUST"), NotNull]
        public double UPUST { get; set; }

        [Column(Name = "NETTO_PRZED_U"), NotNull]
        public double NETTO_PRZED_U { get; set; }

        [Column(Name = "BRUTTO_PRZED_U"), NotNull]
        public double BRUTTO_PRZED_U { get; set; }

        [Column(Name = "URZEDOWE"), Nullable]
        public int? URZEDOWE { get; set; }

        [Column(Name = "IDTEKSTU"), Nullable]
        public int? IDTEKSTU { get; set; }

        [Column(Name = "IDKONTA_KSIEGOWEGO")]
        public int IDKONTA_KSIEGOWEGO { get; set; } = 0;

        [Column(Name = "KONTOVAT"), Nullable]
        public string KONTOVAT { get; set; }

        [Column(Name = "IDVAT")]
        public int IDVAT { get; set; } = 0;

        [Column(Name = "KWOTA"), NotNull]
        public double KWOTA { get; set; }

        [Column(Name = "SPED_TRANS")]
        public int SPED_TRANS { get; set; } = 0;

        [Column(Name = "KATEGORIAF")]
        public int KATEGORIAF { get; set; } = 0;

        [Column(Name = "TRESC_ENG"), Nullable]
        public string TRESC_ENG { get; set; }

        [Column(Name = "ID_NAZWA_TOWARU")] // IdTowaryStawki;
        public int ID_NAZWA_TOWARU { get; set; } = 0;

        [Column(Name = "KURS"), NotNull]
        public double KURS { get; set; }

        [Column(Name = "LP"), NotNull]
        public int LP { get; set; } = 1;

        [Column(Name = "POLE"), NotNull]
        public int POLE { get; set; } = 1;


    }
}
