using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Kontrahenci
{
    [Table(Name = "KONTRAHENCI_ODDZIALY")]
    internal class Kontrahenci_Oddzialy_ORM
    {
        [PrimaryKey, NotNull]
        [Column(Name = "ID_KONTRAHENTA")]
        public int IdKontrahenta { get; set; }

        [PrimaryKey, NotNull]
        [Column(Name = "ID_ODDZIALU")]
        public int IdOddzialu { get; set; }

    }
}
