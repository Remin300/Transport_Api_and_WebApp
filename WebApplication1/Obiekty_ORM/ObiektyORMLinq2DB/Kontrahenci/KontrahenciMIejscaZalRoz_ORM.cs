using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Kontrahenci
{
    [Table(Name = "MIEJSCA")] // Mapowanie do tabeli w bazie danych
    internal class KontrahenciMIejscaZalRoz_ORM
    {
        [PrimaryKey, Identity] // Klucz główny
        [Column(Name = "ID_MIEJSCA")]
        public int ID_KONTRACHENCI_MIEJSCA_ZAL_ROZ { get; set; }

        [Column(Name = "ID_KONTRAHENTA")]
        public int? ID_KONTRAHENTA { get; set; }

        [Column(Name = "ID_ZRP")]
        public int? ID_ZRP { get; set; }

        [Column(Name = "MIASTO")]
        public string? MIASTO { get; set; }

        [Column(Name = "KOD")]
        public string? KOD { get; set; }

        [Column(Name = "ADRES")]
        public string? ADRES { get; set; }

        [Column(Name = "ID_KRAJU")]
        public int? ID_KRAJU { get; set; }

        [Column(Name = "UWAGI")]
        public string? UWAGI { get; set; }
        [Column(Name = "NAZWA")]
        public string? NAZWA_MIEJSCA { get; set; }
        [Column(Name = "DOFAKTURY")]
        public string? DOFAKTURY { get; set; }
     


    }
}





//[Table(Name = "KONTRAHENCI_MIEJSCA_ZAL_ROZ")] // Mapowanie do tabeli w bazie danych
//internal class KontrahenciMIejscaZalRoz_ORM
//{
//    [PrimaryKey, Identity] // Klucz główny
//    [Column(Name = "ID_KONTRACHENCI_MIEJSCA_ZAL_ROZ")]
//    public int ID_KONTRACHENCI_MIEJSCA_ZAL_ROZ { get; set; }

//    [Column(Name = "ID_KONTRAHENTA")]
//    public int? ID_KONTRAHENTA { get; set; }

//    [Column(Name = "MIASTO")]
//    public string? MIASTO { get; set; }

//    [Column(Name = "KOD")]
//    public string? KOD { get; set; }

//    [Column(Name = "ADRES")]
//    public string? ADRES { get; set; }

//    [Column(Name = "ID_KRAJU")]
//    public int? ID_KRAJU { get; set; }

//    [Column(Name = "UWAGI")]
//    public string? UWAGI { get; set; }
//    [Column(Name = "NAZWA_MIEJSCA")]
//    public string? NAZWA_MIEJSCA { get; set; }



//}