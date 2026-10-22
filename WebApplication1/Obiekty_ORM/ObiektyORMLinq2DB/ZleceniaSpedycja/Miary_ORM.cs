using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja
{
    [Table(Name = "MIARY")]
    internal class Miary_ORM
    {
        [PrimaryKey]
        [Column(Name = "ID_MIARY")]
        public int IdMiary { get; set; }

        [Column(Name = "NAZWA")]
        public string Nazwa { get; set; }

        [Column(Name = "SKROT")]
        public string Skrot { get; set; }
    }
}
