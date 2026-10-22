using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Faktury
{

    [Table(Name = "RACH_KOSZTY_TABOR_REJESTR")]
    internal class RACH_KOSZTY_TABOR_REJESTR_ORM
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_REJESTR")]
        public int ID_REJESTR { get; set; }

        [Column(Name = "OPIS")]
        public string OPIS { get; set; }

        [Column(Name = "OPIS1")]
        public string OPIS1 { get; set; }

        [Column(Name = "DODATKOWE1")]
        public int DODATKOWE1 { get; set; }

        [Column(Name = "DODATKOWE2")]
        public int DODATKOWE2 { get; set; }

        [Column(Name = "DODATKOWE3")]
        public int DODATKOWE3 { get; set; }




    }
}
