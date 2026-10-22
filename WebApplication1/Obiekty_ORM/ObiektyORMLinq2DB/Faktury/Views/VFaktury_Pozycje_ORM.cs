using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Faktury.Views
{
    [Table(Name = "VFAKTURY_POZYCJE_NEW")]
    public class VFaktury_Pozycje_ORM
    {
        [Column(Name = "ID_POZYCJI"), PrimaryKey, NotNull]
        public int ID_POZYCJI { get; set; }

        [Column(Name = "ID_FAKTURY"), NotNull]
        public int ID_FAKTURY { get; set; }

        [Column(Name = "TRESC"), NotNull]
        public string TRESC { get; set; }

        [Column(Name = "WALUTA"), Nullable]
        public string WALUTA { get; set; }

        [Column(Name = "KURS"), Nullable]
        public double KURS { get; set; }
        [Column(Name = "ID_VAT"), NotNull]
        public int ID_VAT { get; set; }

        [Column(Name = "JM"), Nullable]
        public string JM { get; set; }

        [Column(Name = "ILOSC"), NotNull]
        public double ILOSC { get; set; }

        [Column(Name = "STAWKA_VAT"), Nullable]
        public string STAWKA_VAT { get; set; }

        [Column(Name = "STAWKA_VAT_OPIS"), Nullable]
        public string STAWKA_VAT_OPIS { get; set; }

        [Column(Name = "CENA_JEDNOSTKOWA_PLN"), Nullable]
        public double CENA_JEDNOSTKOWA_PLN { get; set; }

        [Column(Name = "CENA_NETTO_PLN_CALOSC"), Nullable]
        public double CENA_NETTO_PLN_CALOSC { get; set; }

        [Column(Name = "CENA_BRUTTO_PLN_CALOSC"), Nullable]
        public double CENA_BRUTTO_PLN_CALOSC { get; set; }

        [Column(Name = "PODATEK_PLN"), Nullable]
        public double PODATEK_PLN { get; set; }

        [Column(Name = "CENA_JEDNOSTKOWA_WALUTA"), Nullable]
        public double CENA_JEDNOSTKOWA_WALUTA { get; set; }

        [Column(Name = "CENA_NETTO_W_WALUCIE_CALOSC"), Nullable]
        public double CENA_NETTO_W_WALUCIE_CALOSC { get; set; }

        [Column(Name = "CENA_BRUTTO_W_WALUCIE_CALOSC"), Nullable]
        public double CENA_BRUTTO_W_WALUCIE_CALOSC { get; set; }

        [Column(Name = "PODATEK_W_WALUCIE_CALOSC"), Nullable]
        public double PODATEK_W_WALUCIE_CALOSC { get; set; }
        [Column(Name = "TABELA"), Nullable]
        public string TABELA { get; set; }
        [Column(Name = "ZDNIA"), Nullable]
        public DateTime? ZDNIA { get; set; }


    }
}
