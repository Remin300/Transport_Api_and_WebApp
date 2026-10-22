using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Faktury
{
    [Table(Name = "RACH_KOSZTY_TABOR_REJESTR")]
    internal class Rachunek_Koszty_Tabor_Rejestr_ORM
    {
        [PrimaryKey]
        [Column(Name = "ID_REJESTR")]
        public int IdRejestr { get; set; }

        [Column(Name = "OPIS")]
        public string? Opis { get; set; }

        [Column(Name = "OPIS1")]
        public string? Opis1 { get; set; }

        [Column(Name = "DODATKOWE1")]
        public int? Dodatkowe1 { get; set; }

        [Column(Name = "DODATKOWE2")]
        public int? Dodatkowe2 { get; set; }

        [Column(Name = "DODATKOWE3")]
        public int? Dodatkowe3 { get; set; }
    }
}
