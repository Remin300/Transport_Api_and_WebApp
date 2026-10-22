using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja.Views
{
    [Table(Name = "VTOWARY_ZBIOR_POJAZDNEW")]
    internal class VTowaryZbiorPojazd_ORM
    {
        [Column(Name = "ID_TOWARU")]
        public int IdTowaru { get; set; }

        [Column(Name = "ID_ZLECENIA")]
        public int IdZlecenia { get; set; }

        [Column(Name = "LP")]
        public int Lp { get; set; }

        [Column(Name = "NR_FAKTURY")]
        public string NR_FAKTURY { get; set; }

        [Column(Name = "IMPORTER")]
        public string Importer { get; set; }

        [Column(Name = "IMPORTERADRES")]
        public string ImporterAdres { get; set; }

        [Column(Name = "ODBIORCA")]
        public string Odbiorca { get; set; }

        [Column(Name = "ODBIORCAADRES")]
        public string OdbiorcaAdres { get; set; }

        [Column(Name = "ODBIORCAADRES2")]
        public string OdbiorcaAdres2 { get; set; }

        [Column(Name = "EKSPORTER")]
        public string Eksporter { get; set; }

        [Column(Name = "EKSPORTERADRES")]
        public string EksporterAdres { get; set; }

        [Column(Name = "DOSTAWCA")]
        public string Dostawca { get; set; }

        [Column(Name = "DOSTAWCAADRES")]
        public string DostawcaAdres { get; set; }
        [Column(Name = "DOSTAWCAADRES2")]
        public string DostawcaAdres2 { get; set; }

        [Column(Name = "TOWAR")]
        public string Towar { get; set; }

        [Column(Name = "TOWAR_NR")]
        public int TowarNr { get; set; }

        [Column(Name = "DATAWYSYLKI")]
        public DateTime DATAWYSYLKI { get; set; }

        [Column(Name = "DATADOSTARCZENIA")]
        public DateTime DATADOSTARCZENIA { get; set; }
        
        [Column(Name = "PLATNIK")]
        public string PLATNIK { get; set; }
    }
}
