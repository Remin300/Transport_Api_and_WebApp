using LinqToDB.Mapping;



namespace WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja
{

    [Table(Name = "POJAZDY_SL")] // Określenie nazwy tabeli
    internal class POJAZDY_SL_ORM
    {
        [Column(Name = "ID_POJAZDU"), PrimaryKey]
        public int ID_POJAZDU { get; set; }
        [Column(Name = "NR_REJ")]
        public string NR_REJ { get; set; }
        [Column(Name = "ID_DZIAL")]
        public int ID_DZIAL { get; set; }
        [Column(Name = "KONTO_MA")]
        public string KONTO_MA { get; set; }
        [Column(Name = "KONTO_WN")]
        public string KONTO_WN { get; set; }
        [Column(Name = "DZIAL")]
        public string DZIAL { get; set; }
        [Column(Name = "KONTO_WN1")]
        public string KONTO_WN1 { get; set; }
    }
}
