using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja.Views
{
    [Table(Name = "VZLECENIA_SPED")]   //  POLBOT = VZLECENIA_SPED_OLD ; THOUSE = VZLECENIA_SPED
    internal class VZleceniaSped_ORM
    {
        [Column(Name = "ID_ZLECENIA_SPED")]
        public int IdZleceniaSped { get; set; }

        [Column(Name = "NR_KOLEJNY")]
        public int? NrKolejny { get; set; }

        [Column(Name = "NUMER_PELNY")]
        public string NumerPelny { get; set; }

        [Column(Name = "NAZWAZLECENIODAWCY")]
        public string NazwaZleceniodawcy { get; set; }

        [Column(Name = "DATA_ZLECENIA")]
        public DateTime? DataZlecenia { get; set; }

        [Column(Name = "ID_FAKTURY")]
        public int? IdFaktury { get; set; }

        [Column(Name = "REJPOJAZDU")]
        public string RejPojazdu { get; set; }

        [Column(Name = "REJNACZEPY")]
        public string RejNaczepy { get; set; }

        [Column(Name = "NUMER_FAKTURY")]
        public string NumerFaktury { get; set; }

        [Column(Name = "NAZWAWYKONAWCY")]
        public string NazwaWykonawcy { get; set; }

        [Column(Name = "IMP_EXP_KRAJ")]
        public int ImpExpKraj { get; set; }

        [Column(Name = "OCZEKUJACE")]
        public int Oczekujace { get; set; }

        [Column(Name = "STAWKA_WLASNA")]
        public double? StawkaWlasna { get; set; }

        [Column(Name = "PRZEWOZNIK_STAWKA")]
        public double? PrzewoznikStawka { get; set; }

        [Column(Name = "LINK_ZLECENIE")]
        public int LinkZlecenie { get; set; }

        [Column(Name = "ID_KATEGORIA")]
        public int? IdKategoria { get; set; }

        [Column(Name = "NAZWAKAT")]
        public string NazwaKat { get; set; }

        [Column(Name = "JAZDA")]
        public int Jazda { get; set; }

        [Column(Name = "NUMER_KSIEGOWY")]
        public string NumerKsiegowy { get; set; }

        [Column(Name = "ZBIOROWKA")]
        public int Zbiorowka { get; set; }

        [Column(Name = "TRASA_DO")]
        public string TrasaDo { get; set; }

        [Column(Name = "NRLECENIODAWCY")]
        public int? NrZleceniodawcy { get; set; }

        [Column(Name = "PRZELADUNEK")]
        public string Przeladunek { get; set; }

        [Column(Name = "FINALIZED")]
        public int? Finalized { get; set; }

        [Column(Name = "KRAJ_NAD")]
        public int KrajNad { get; set; }

        [Column(Name = "KRAJ_ODB")]
        public int KrajOdb { get; set; }

        [Column(Name = "KRAJ_NAD_SYMB")]
        public string KrajNadSymb { get; set; }

        [Column(Name = "KRAJ_ODB_SYMB")]
        public string KrajOdbSymb { get; set; }

        [Column(Name = "OSOBA")]
        public string Osoba { get; set; }

        [Column(Name = "DATA_ZALADUNKU")]
        public DateTime? DataZaladunku { get; set; }

        [Column(Name = "DATA_ROZLADUNKU")]
        public DateTime? DataRozladunku { get; set; }
    }
}
