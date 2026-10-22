using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Faktury.Views
{
    [Table(Name = "V_RACHP_KOSZTY_POZYCJE_NEW")]
    internal class VRachunki_Koszty_Pozycje_ORM
    {
        [Column(Name = "ID_RACHP"), PrimaryKey]
        public int ID_RACHP { get; set; }

        [Column(Name = "ID_RACH")]
        public int ID_RACH { get; set; }

        [Column(Name = "UWAGI")]
        public string UWAGI { get; set; }

        [Column(Name = "WALUTA")]
        public string WALUTA { get; set; }

        [Column(Name = "KURS")]
        public double KURS { get; set; }

        [Column(Name = "ILOSC")]
        public double ILOSC { get; set; }

        [Column(Name = "STAWKA_VAT")]
        public string STAWKA_VAT { get; set; }

        [Column(Name = "STAWKA_VAT_OPIS")]
        public string STAWKA_VAT_OPIS { get; set; }

        [Column(Name = "CENA_JEDNOSTKOWA_PLN")]
        public double CENA_JEDNOSTKOWA_PLN { get; set; }

        [Column(Name = "CENA_NETTO_PLN_CALOSC")]
        public double CENA_NETTO_PLN_CALOSC { get; set; }

        [Column(Name = "CENA_BRUTTO_PLN_CALOSC")]
        public double CENA_BRUTTO_PLN_CALOSC { get; set; }

        [Column(Name = "PODATEK_PLN")]
        public double PODATEK_PLN { get; set; }

        [Column(Name = "CENA_JEDNOSTKOWA_WALUTA")]
        public double CENA_JEDNOSTKOWA_WALUTA { get; set; }

        [Column(Name = "CENA_NETTO_W_WALUCIE_CALOSC")]
        public double CENA_NETTO_W_WALUCIE_CALOSC { get; set; }

        [Column(Name = "CENA_BRUTTO_W_WALUCIE_CALOSC")]
        public double CENA_BRUTTO_W_WALUCIE_CALOSC { get; set; }

        [Column(Name = "PODATEK_W_WALUCIE_CALOSC")]
        public double PODATEK_W_WALUCIE_CALOSC { get; set; }

/*        [Column(Name = "ZAPLACONA")]
        public double ZAPLACONA { get; set; }

        [Column(Name = "ZAPLACONA_BRUTTO")]
        public double ZAPLACONA_BRUTTO { get; set; }*/

        
    }
}
