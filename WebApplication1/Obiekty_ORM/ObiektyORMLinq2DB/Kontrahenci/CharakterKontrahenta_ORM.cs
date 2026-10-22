using LinqToDB.Mapping;


namespace WebApplication1.ObiektyORMLinq2DB.Kontrahenci
{
    [Table(Name = "CHARAKTER_KONTRAHENTA")] // Mapowanie do tabeli w bazie danych
    internal class CharakterKontrahenta_ORM
    {
        [PrimaryKey] // Klucz główny
        [Column(Name = "ID_CHARAKTER_KONTRAHENTA")] // Mapowanie do kolumny
        public int ID_charakteru { get; set; }

        [Column(Name = "OPIS")] // Mapowanie do kolumny
        public string Opis { get; set; }
    }
}
