using LinqToDB.Mapping;
using System.ComponentModel;


namespace WebApplication1.ObiektyORMLinq2DB.TS.Kierowcy
{
    [Table(Name = "KIEROWCY")] // Tabela w bazie danych ma nazwę "KONTRAHENCI"
    internal class Kierowcy_ORM
    {
       [PrimaryKey, Identity] // Klucz główny z autoincrementem
       [Column(Name = "ID_KIEROWCA")]
       public int ID_KIEROWCA { get; set; }
       [Column(Name = "IMIE"), Nullable]
       public string IMIE {  get; set; }
       [Column(Name = "IMIE2"), Nullable]
       public string   IMIE2 
        {            
            get;
            set; }
        [Column(Name = "NAZWISKO"), Nullable]
       public string NAZWISKO {  get; set; }

       [Column(Name = "ADRES"), Nullable]
       public string ADRES {  get; set; }
        [Column(Name = "MIEJSCOWSC"), Nullable]
        public string MIEJSCOWSC { get; set; } 
       [Column(Name = "KOD"), Nullable]               
       public string KOD {  get; set; }
       [Column(Name = "WOJEWODZTWO"), Nullable]
       public string WOJEWODZTWO {  get; set; }
       [Column(Name = "GMINA"), Nullable]
       public string GMINA { get;  set; }
       [Column(Name = "POWIAT"), Nullable]
       public string POWIAT { get;  set; }
       [Column(Name = "POCZTA"), Nullable]
       public string POCZTA {  get; set; }
       [Column(Name = "TEL_DOM"), Nullable]
        public string TEL_DOM {  get; set; }
           [Column(Name = "TEL_KOM"), Nullable]
        public string TEL_KOM {  get; set; }
        [Column(Name = "NIP"), Nullable]
        public string NIP {  get; set; }
       [Column(Name = "PESEL"), Nullable]
        public string PESEL {  get; set; }
       [Column(Name = "IM_OJCA"), Nullable]
       public string IM_OJCA {  get; set; }
       [Column(Name = "IM_MATKI"), Nullable]
        public string IM_MATKI { get; set; }
        [Column(Name = "DATA_UR")]
        public DateTime  DATA_UR { get; set; }
        [Column(Name = "M_URODZ"), Nullable]
        public string M_URODZ  { get;  set; }
        [Column(Name = "REGON"), Nullable]
        public string REGON {  get; set; }
       [Column(Name = "NR_DZIALGOSP"), Nullable]
        public string NR_DZIALGOSP {  get; set; }
        [Column(Name = "GRUPA_ZASZEREGOWANIA"), Nullable]
        public int? GRUPA_ZASZEREGOWANIA { get; set; } = 0;
        [Column(Name = "NIEAKTYWNY"), Nullable]
        public int? NIEAKTYWNY { get; set; } = 0;
        [Column(Name = "TADRES"), Nullable]
        public string TADRES {  get; set; }
        [Column(Name = "TMIEJSCOWSC"), Nullable]
        public string TMIEJSCOWSC { get;  set; }
        [Column(Name = "TKOD"), Nullable]
        public string TKOD {  get; set; }
        [Column(Name = "TWOJEWODZTWO"), Nullable]
        public string TWOJEWODZTWO { get;  set; }
        [Column(Name = "TGMINA"), Nullable]
        public string TGMINA { get;  set; }
        [Column(Name = "DOWOD"), Nullable]
        public string DOWOD {  get; set; }
        [Column(Name = "WYDPRZEZ"), Nullable]
        public string WYDPRZEZ {  get; set; }
        [Column(Name = "DATAWYD")]
        public DateTime DATAWYD {  get; set; }
        [Column(Name = "PLN")]
        public double PLN {  get; set; }
        [Column(Name = "EUR")]
        public double EUR {  get; set; }
        [Column(Name = "GBP")]
        public double GBP { get; set; }
        [Column(Name = "USD")]
        public double USD {  get; set; }
        [Column(Name = "AKTUALNE_ZATR"), Nullable]
        public string AKTUALNE_ZATR {  get; set; }
        [Column(Name = "DATA_ZATRUDNIENIA"), Nullable]
        public DateTime DATA_ZATRUDNIENIA {  get; set; }
        [Column(Name = "PRAKTYKA"), Nullable]
        public string PRAKTYKA{ get; set; }
        [Column(Name = "UMOWA"), Nullable]
        public string UMOWA {  get; set; }
        [Column(Name = "STAN_CYWILNY"), Nullable]
        public string STAN_CYWILNY {  get; set; }
        [Column(Name = "DZIECI"), Nullable]
        public string DZIECI {  get; set; }
        [Column(Name = "DATA_UMOWA"), Nullable]
        public DateTime DATA_UMOWA {  get; set; }
        [Column(Name = "DATA_ZW")] //, Nullable
        public DateTime DATA_ZW {  get; set; }
       [Column(Name = "DATA_ZWOLNIENIA"), Nullable]
       public DateTime DATA_ZWOLNIENIA { get; set; }
       [Column(Name = "STANOWISKO"), Nullable]
       public int? STANOWISKO { get; set; } = 0;
       [Column(Name = "NACZEPA"), Nullable]
       public string NACZEPA {  get; set; }
       [Column(Name = "ID_WYKONAWCA")]
       public int? ID_WYKONAWCA { get; set; } = 0;
       [Column(Name = "POJAZD"), Nullable]
       public string POJAZD { get; set; }
        [Column(Name = "OBCY")]
        public int? OBCY { get; set; } = 0;
        [Column(Name = "FIRMA")]
        public int? FIRMA { get; set; } = 0;
        [Column(Name = "IDWYKSZTALCENIA")]
        public int? IDWYKSZTALCENIA { get; set; } = 0;
        [Column(Name = "ID_USER")]
        public int? ID_USER { get; set; } = 0;
        [Column(Name = "PRANIE")]
        public double PRANIE { get; set; }
        [Column(Name = "KOMORNIK")]
        public double KOMORNIK { get; set; }
        [Column(Name = "SAMOCHOD")]
        public double SAMOCHOD { get; set; }
        [Column(Name = "DNIOWKA")]
        public double DNIOWKA { get; set; }
        [Column(Name = "OPERATOR"), Nullable]
        public string OPERATOR { get; set; }
        [Column(Name = "ABONAMENT")]
        public double ABONAMENT { get; set; }
        [Column(Name = "ABONAMENT_DODATKOWY")]
        public double ABONAMENT_DODATKOWY { get; set; }
        [Column(Name = "NAZWA_TARYFY"), Nullable]
        public string NAZWA_TARYFY { get; set; }
        [Column(Name = "DATA_OTRZYMANIA"), Nullable]
        public DateTime DATA_OTRZYMANIA { get; set; }
        [Column(Name = "MODEL"), Nullable]
        public string MODEL {  get; set; }
        [Column(Name = "IMEI"), Nullable]
        public string IMEI {  get; set; }
        [Column(Name = "PIN"), Nullable]
        public string PIN {  get; set; }
     [Column(Name = "HASLO"), Nullable]
     public string HASLO {  get; set; }
     [Column(Name = "IDBUS"), Nullable]
     public int? IDBUS { get; set; } = 0;
     [Column(Name = "SKYP"), Nullable]
     public string SKYP {  get; set; }
     [Column(Name = "MAIL"), Nullable]
     public string MAIL {  get; set; }
     [Column(Name = "GRUPA")]
     public int? GRUPA { get; set; } = 0;
     [Column(Name = "URZAD")]
     public int? URZAD { get; set; } = 0;        
     [Column(Name = "TE_AU")]
     public int? TE_AU { get; set; } = 0;
     [Column(Name = "TE_CS")]
     public int? TE_CS { get; set; } = 0;
     [Column(Name = "TE_FR")]
     public int? TE_FR { get; set; } = 0;
     [Column(Name = "TE_DE")]
     public int? TE_DE { get; set; } = 0;
    [Column(Name = "TE_IT")]
     public int? TE_IT { get; set; } = 0;
    [Column(Name = "DZIAL")]
    public int? DZIAL { get; set; } = 0;

        
    }
}
