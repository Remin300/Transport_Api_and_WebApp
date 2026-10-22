using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Grupy_Dzialy_Filtry
{
    [Table(Name = "ODDZIALY")]
    public class Oddzialy_ORM
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_OT")]
        public int ID_OT { get; set; }

        [Column(Name = "SKROT")]
        public string SKROT { get; set; }

        [Column(Name = "NAZWA")]  // daj rozszerzenie konta
        public string NAZWA { get; set; }

        [Column(Name = "IDREJESTR")]
        public int IDREJESTR { get; set; }
        [Column(Name = "IDREJESTREU")]
        // burian firma z oddzialami
        public int IDREJESTREU { get; set; }

        [Column(Name = "KONTO1")]  // koszty 400
        public string KONTO1 { get; set; }

        [Column(Name = "KONTO2")]  // sprzedaz 500
        public string KONTO2 { get; set; }

        [Column(Name = "KONTO3")]  // koszty 400
        public string KONTO3 { get; set; }

        [Column(Name = "KONTO4")]  // sprzedaz 500
        public string KONTO4 { get; set; }

        [Column(Name = "KONTO5")]  // koszty 400
        public string KONTO5 { get; set; }

        [Column(Name = "KONTO6")]  // sprzedaz 500
        public string KONTO6 { get; set; }

        [Column(Name = "KONTO7")]  // koszty 400
        public string KONTO7 { get; set; }

        [Column(Name = "KONTO8")]  // sprzedaz 500
        public string KONTO8 { get; set; }

        [Column(Name = "KONTO9")]  // koszty 400
        public string KONTO9 { get; set; }

        [Column(Name = "KONTO10")]  // sprzedaz 500
        public string KONTO10 { get; set; }


        [Column(Name = "OPIS1")]  // sprzedaz 500
        public string OPIS1 { get; set; }
        [Column(Name = "OPIS2")]  // sprzedaz 500
        public string OPIS2 { get; set; }


    }
}
