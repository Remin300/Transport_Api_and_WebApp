using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Poczta_Paczki
{
    [Table(Name = "POCZTA_SLOWNIK")]
    internal class POCZTA_SLOWNIK_ORM
    {
        [PrimaryKey, Identity]
        public int ID { get; set; }

        [Column, NotNull]
        public string OPIS { get; set; }
    }
}
