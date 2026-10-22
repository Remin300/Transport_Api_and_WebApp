using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Kontrahenci
{

    [Table(Name = "RODZAJE_PLATNOSCI")] // Nazwa tabeli w bazie danych
    internal class RodzajePlatnosci_ORM
    {
        [PrimaryKey] // Klucz główny
        [Column(Name = "ID_RODZ_PLATNOSCI")] // Mapowanie do kolumny
        public int IdRodzPlatnosci { get; set; }

        [Column(Name = "OPIS")] // Mapowanie do kolumny
        public string Opis { get; set; }

        [Column(Name = "OPISEN")] // Mapowanie do kolumny
        public string OpisEn { get; set; }

        [Column(Name = "OPISDE")] // Mapowanie do kolumny
        public string OpisDe { get; set; }

        [Column(Name = "OPISFR")] // Mapowanie do kolumny
        public string OpisFr { get; set; }
    }
}
