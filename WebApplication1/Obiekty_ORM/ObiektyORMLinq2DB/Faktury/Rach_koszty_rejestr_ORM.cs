using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Faktury
{
    [Table(Name = "RACH_KOSZTY_TABOR_REJESTR")]
    internal class Rach_koszty_rejestr_ORM
    {
        [PrimaryKey, Identity]
        [Column("ID_REJESTR")]
        public int ID_REJESTR { get; set; }

        [Column("OPIS")]
        public string OPIS { get; set; }

        [Column("OPIS1")]
        public string OPIS1 { get; set; }

        [Column("DODATKOWE1")]
        public int? DODATKOWE1 { get; set; } = 0;
        [Column("DODATKOWE2")]
        public int? DODATKOWE2 { get; set; } = 0;
        [Column("DODATKOWE3")]
        public int? DODATKOWE3 { get; set; } = 0;
    }
}
