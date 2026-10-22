using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja
{
    [Table(Name = "SYMBOLE_WALUT")]
    internal class SymboleWalut_ORM
    {
        [PrimaryKey]
        [Column(Name = "ID_WALUTY")]
        public int IdWaluty { get; set; }

        [Column(Name = "ID_KRAJU")]
        public int IdKraju { get; set; }

        [Column(Name = "SYMBOL")]
        public string Symbol { get; set; }

        [Column(Name = "NAZWA")]
        public string Nazwa { get; set; }

        [Column(Name = "DEF_ILOSC")]
        public int DefIlosc { get; set; }

        [Column(Name = "HTTPSTRING")]
        public string HttpString { get; set; }
    }
}
