using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.DaneFirmy
{
    //[Column(Name = "RACHUNEK2")] // UWAGA FAKTORING TAK NIE
    // ["Rachunek3"].HeaderText = "Opis-Faktoring"; PRZEDŁUŻYĆ DO 1000 STRING
    //[Column(Name = "DEFAULT_KONTO")] // 1 - pln, 2 - €

    [Table(Name = "KONTA_BANKOWE")] // Nazwa tabeli w bazie danych
    public class WlasneKontaBankowe_ORM
    {
        [PrimaryKey] // Klucz główny
        [Column(Name = "ID_KONTA")] // Mapowanie do kolumny
        public int IdKonta { get; set; }

        [Column(Name = "BANK")] // Mapowanie do kolumny
        public string Bank { get; set; }

        [Column(Name = "RACHUNEK")] // Mapowanie do kolumny
        public string Rachunek { get; set; }

        [Column(Name = "SWITH")] // Mapowanie do kolumny
        public string SWITH { get; set; }

        [Column(Name = "OPIS")] // Mapowanie do kolumny
        public string Opis { get; set; }

        [Column(Name = "DEFAULT_KONTO")] // 1 - pln, 2 - €
        public int DefaultKonto { get; set; }

        [Column(Name = "AKTYWNE")]  ///
        public int AKTYWNE { get; set; } = 0;

        [Column(Name = "IDWALUTY")]
        public int IDWALUTY { get; set; } = 0;

        [Column(Name = "RACHUNEK1")] // DODATKOWY OPIS 
        public string Rachunek1 { get; set; }


        [Column(Name = "RACHUNEK2")] // UWAGA FAKTORING TAK NIE
        public string Rachunek2 { get; set; }

        [Column(Name = "RACHUNEK3")] // Opis Faktoringu !!!
        public string Rachunek3 { get; set; }
        [Column(Name = "RACHUNEK4")] // Opis Faktoringu !!!
        public string Rachunek4 { get; set; }

        [Column(Name = "FIRMY_ID")]
        public int FIRMY_ID { get; set; } = 0;


    }
}
