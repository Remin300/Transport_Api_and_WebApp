using LinqToDB.Mapping;

namespace WebApplication1.Obiekty_ORM.ObiektyORMLinq2DB.Urzytkownicy
{
    [Table(Name = "USERS")]
    public class Users_ORM
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_USER")]
        public int ID_USER { get; set; }

        [Column(Name = "LOGIN")]
        public string LOGIN { get; set; }

        [Column(Name = "PASS")]
        public string PASS { get; set; }

        [Column(Name = "IMIE")]
        public string IMIE { get; set; }

        [Column(Name = "NAZWISKO")]
        public string NAZWISKO { get; set; }

        [Column(Name = "ID_GRUPY")]
        public int? ID_GRUPY { get; set; }

        [Column(Name = "IDGRUPA")]
        public int? IDGRUPA { get; set; }


        [Column(Name = "VISIBLE")]
        public int? VISIBLE { get; set; }

        [Column(Name = "ADRES")]
        public string ADRES { get; set; }

        [Column(Name = "KOD")]
        public string KOD { get; set; }

        [Column(Name = "MIASTO")]
        public string MIASTO { get; set; }

        [Column(Name = "LOCK")]
        public int? LOCK { get; set; }

        [Column(Name = "PASSCHANGED")]
        public DateTime? PASSCHANGED { get; set; }

        [Column(Name = "PASS_NOWY_PROGRAM")]
        public string PASS_NOWY_PROGRAM { get; set; }

        [Column(Name = "KSEF_TOKEN")]
        public string KSEF_TOKEN { get; set; }

        [Column(Name = "ID_ROLA")]
        public int ID_ROLA { get; set; }  // FK do tabeli ROLE
        [Column(Name = "IDREJESTR")]
        public int IDREJESTR { get; set; }  // defaultowy rejestr dla fakturzystki !


        [Column(Name = "WARUNEK")] // mail
        public string WARUNEK { get; set; }
        [Column(Name = "PASSODKOD")] // mail
        public string PASSODKOD { get; set; }
        [Column(Name = "GRUPA")] // mail
        public string GRUPA { get; set; }

        
    }
}
