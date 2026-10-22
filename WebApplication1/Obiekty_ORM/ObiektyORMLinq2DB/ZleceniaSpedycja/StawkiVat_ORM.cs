using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja
{
    [Table(Name = "STAWKI_VAT")]
    public class StawkiVat_ORM
    {
        [PrimaryKey] 
        [Column(Name = "ID_STAWKI")]
        public int IdStawki { get; set; }

        [Column(Name = "OPIS")]
        public string Opis { get; set; }

        [Column(Name = "PROCENT")]
        public double Procent { get; set; }

        [Column(Name = "KSEF_NAZWA")]
        public string KSEF_NAZWA { get; set; }

        [Column(Name = "OPIS_STAWKI")]
        public string OPIS_STAWKI { get; set; }

        [Column(Name = "PROCEDURA")]
        public int PROCEDURA { get; set; }

    }
}
