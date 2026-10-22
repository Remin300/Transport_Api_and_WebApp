using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja
{
    [Table(Name = "KATEGORIE_ZLECEN")]
    internal class KategorieZlecenia_ORM
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_KATEGORIA")]
        public int ID_KATEGORIA { get; set; }

        [Column(Name = "OPIS")]
        public string OPIS { get; set; }
    }
}
