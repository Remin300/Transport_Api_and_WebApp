using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Kontrahenci
{
    [Table(Name = "OSOBY_KONTAKTOWE")] // Mapowanie do tabeli w bazie danych
    internal class KontrahenciOsoby_ORM
    {
        [PrimaryKey] // Klucz główny
        [Column(Name = "ID_OSOBY")] // Mapowanie do kolumny
        public int ID_OSOBY { get; set; }

        [Column(Name = "ID_KONTRAHENTA")] // Mapowanie do kolumny
        public int ID_KONTRAHENTA { get; set; }

        [Column(Name = "IMIE")] // Mapowanie do kolumny
        public string Imie { get; set; }

        [Column(Name = "NAZWISKO")] // Mapowanie do kolumny
        public string Nazwisko { get; set; }

        [Column(Name = "STANOWISKO")] // Mapowanie do kolumny
        public string Stanowisko { get; set; }

        [Column(Name = "KONTAKT")] // Mapowanie do kolumny
        public string Kontakt { get; set; }

        [Column(Name = "OPIS")] // Mapowanie do kolumny
        public string Opis { get; set; }

        [Column(Name = "EMAIL")] // Mapowanie do kolumny
        public string Email { get; set; }

        [Column(Name = "TELEFON")] // Mapowanie do kolumny
        public string Telefon { get; set; }

        [Column(Name = "KOMORKA")] // Mapowanie do kolumny
        public string Komorka { get; set; }

        [Column(Name = "ADRES")] // Mapowanie do kolumny
        public string Adres { get; set; }
    }
}
