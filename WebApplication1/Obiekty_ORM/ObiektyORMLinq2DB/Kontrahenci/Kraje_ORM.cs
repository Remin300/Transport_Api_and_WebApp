using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Kontrahenci
{
    [Table(Name = "KRAJE")] // Nazwa tabeli w bazie danych
    internal class Kraje_ORM
    {
        [PrimaryKey] // Klucz główny
        [Column(Name = "ID_KRAJU")] // Mapowanie do kolumny
        public int IdKraju { get; set; }

        [Column(Name = "SYMBOL")] // Mapowanie do kolumny
        public string Symbol { get; set; }

        [Column(Name = "NAZWA")] // Mapowanie do kolumny
        public string Nazwa { get; set; }

        [Column(Name = "HTTPSTRING")] // Mapowanie do kolumny
        public string HttpString { get; set; }

        [Column(Name = "KOD_POCZTOWY_MASKA")] // Mapowanie do kolumny
        public string KodPocztowyMaska { get; set; }

        [Column(Name = "UNIA")] // Mapowanie do kolumny
        public int Unia { get; set; }

    }
}
