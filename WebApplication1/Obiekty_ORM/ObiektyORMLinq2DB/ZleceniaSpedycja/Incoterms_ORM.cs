using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja
{

    [Table(Name = "INCOTERMS")] // Określenie nazwy tabeli
    internal class Incoterms_ORM
    {
        [PrimaryKey] // Klucz główny
        [Column(Name = "ID_INCOTERMS")] // Mapowanie do kolumny
        public int IdIncoterms { get; set; }

        [Column(Name = "SKROT")] // Mapowanie do kolumny
        public string Skrot { get; set; }

        [Column(Name = "OPIS")] // Mapowanie do kolumny
        public string Opis { get; set; }
    }
}
