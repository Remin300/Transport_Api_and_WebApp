using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja
{
    [Table(Name = "MIEJSCA_ZALAD_ROZLAD")]
    public class MiejscaZaladRozlad_ORM
    {

        [PrimaryKey, Identity]
        [Column(Name = "ID_MIEJSCA_ZALAD_ROZLAD")]
        public int ID_MIEJSCA_ZALAD_ROZLAD { get; set; }

        [Column(Name = "ID_ZLECENIA"), Nullable]
        public int ID_ZLECENIA { get; set; }

        [Column(Name = "ID_ZRP"), Nullable]
        public int? ID_ZRP { get; set; }   // 1 - załadunek       2 - rozładunek

        [Column(Name = "LP"), Nullable]
        public int? LP { get; set; }

        [Column(Name = "NAZWA"), Nullable]
        public string? NAZWA { get; set; }

        [Column(Name = "ADRES"), Nullable]
        public string? ADRES { get; set; }

        [Column(Name = "KOD"), Nullable]
        public string? KOD { get; set; }

        [Column(Name = "MIASTO"), Nullable]
        public string? MIASTO { get; set; }

        [Column(Name = "ID_KRAJU"), Nullable]
        public int? ID_KRAJU { get; set; }

        [Column(Name = "UWAGI"), Nullable]
        public string? UWAGI { get; set; }

        [Column(Name = "DOFAKTURY"), Nullable]
        public string? DOFAKTURY { get; set; }


        // POLA NIEISTOTNE

        //[Column(Name = "ID_MIEJSCA"), Nullable]
        //public int? IdMiejsca { get; set; }

        //[Column(Name = "ID_PRZESYLKI"), Nullable]
        //public int? IdPrzesylki { get; set; }

        //[Column(Name = "KWOTAEUR"), Nullable]
        //public double? KwotaEur { get; set; }

        //[Column(Name = "GODZINA"), Nullable]
        //public string? Godzina { get; set; }

        //[Column(Name = "DATA"), Nullable]
        //public DateTime? Data { get; set; }

        //[Column(Name = "KWOTAPLN"), Nullable]
        //public double? KwotaPln { get; set; }

        //[Column(Name = "ID_VAT"), Nullable]
        //public int? IdVat { get; set; }

        //[Column(Name = "KIEROWCA"), Nullable]
        //public string? Kierowca { get; set; }

        //[Column(Name = "POJAZD"), Nullable]
        //public string? Pojazd { get; set; }

        //[Column(Name = "ID_WALUTA"), Nullable]
        //public int? IdWaluta { get; set; }

        //[Column(Name = "KWOTA"), Nullable]
        //public double? Kwota { get; set; }

        //[Column(Name = "ID_WYKONAWCY"), Nullable]
        //public int? IdWykonawcy { get; set; }

        //[Column(Name = "ID_KONTRAHENTA"), Nullable]
        //public int? IdKontrahenta { get; set; }

    }
}
