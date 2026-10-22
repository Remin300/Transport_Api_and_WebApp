using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Kontrahenci
{
    [Table(Name = "KONTRAHENCI_KONTA")] // Mapowanie do tabeli w bazie danych
    internal class KontrahentKonta_ORM
    {
        [PrimaryKey] // Klucz główny
        [Column(Name = "ID_KONTA")] // Mapowanie do kolumny
        public int ID_Konta { get; set; }

        [Column(Name = "ID_KONTRAHENTA")] // Mapowanie do kolumny
        public int ID_Kontrahenta { get; set; }

        [Column(Name = "NAZWA")] // Mapowanie do kolumny
        public string Nazwa { get; set; }

        [Column(Name = "ADRES")] // Mapowanie do kolumny
        public string Adres { get; set; }

        [Column(Name = "NUMER")] // Mapowanie do kolumny
        public string Numer { get; set; }

        [Column(Name = "OPIS")] // Mapowanie do kolumny
        public string Opis { get; set; }

        [Column(Name = "DOMYSLNE")] // Mapowanie do kolumny
        public int Domyslne { get; set; }


        [Column(Name = "SWITH")] // Mapowanie do kolumny
        public string SWITH { get; set; }

        [Column(Name = "EMAIL")] // Mapowanie do kolumny
        public string EMAIL { get; set; }

    }
}
