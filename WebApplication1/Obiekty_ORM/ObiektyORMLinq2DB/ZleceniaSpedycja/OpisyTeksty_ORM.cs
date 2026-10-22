using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja
{
    [Table(Name = "OPISY_TEKSTY")]
    internal class OpisyTeksty_ORM
    {

            [PrimaryKey]
            [Column(Name = "ID_TEKSTU")]
            public int ID_TEKSTU { get; set; }

            [Column(Name = "OPIS")]
            public string OPIS { get; set; }

            [Column(Name = "TEKST1")]
            public string TEKST1 { get; set; }

            [Column(Name = "TEKST2")]
            public string TEKST2 { get; set; }

            [Column(Name = "TEKST3")]
            public string TEKST3 { get; set; }

            [Column(Name = "TEKST4")]
            public string TEKST4 { get; set; }

            [Column(Name = "TEKST5")]
            public string TEKST5 { get; set; }

            [Column(Name = "TEKST6")]
            public string TEKST6 { get; set; }

    }
}
