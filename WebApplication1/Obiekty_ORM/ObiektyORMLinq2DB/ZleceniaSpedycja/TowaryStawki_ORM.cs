using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja
{
    [Table(Name = "TOWARY_STAWKI")]
    internal class TowaryStawki_ORM
    {

        // UWAGA BLAD NAZEWNICTWA W BAZIE DANYCH  
        // Tabela TOWARY_STAWKI posiada klucz obcy do tabeli "FAKTURY" pod nazwa "IDFAKTURY_POZYCJE"
        //  i klucz obcy do tabeli "FAKTURY_POZYCJE" pod nazwa "ID_FAKTURY"


        [PrimaryKey]
        [Column(Name = "ID_TOWARY_STAWKI")]
        public int IdTowaryStawki { get; set; }

        [Column(Name = "IDSTAWKI")]
        public int IdSlownikStawek { get; set; }  // UWAGA KLUCZ OBCY DO SŁOWNIKA

        [Column(Name = "OPIS")]
        public string Opis { get; set; }

        [Column(Name = "KWOTA_W_WALUCIE")]
        public double? KwotaWWalucie { get; set; }

        [Column(Name = "IDWALUTY")]
        public int? IdWaluty { get; set; }

        [Column(Name = "IDVAT")]
        public int IdVat { get; set; }

        [Column(Name = "IDFAKTURY_POZYCJE")]
        public int? IDFAKTURY_POZYCJE { get; set; } = 0; // UWAGA to klucz obcy do tabeli FAKTURY

        [Column(Name = "IDJEDNOSTKA_MIAR")]
        public int IdJednostkaMiar { get; set; }

        [Column(Name = "ILOSC")]
        public double? Ilosc { get; set; }

        [Column(Name = "IDTOWARU")]
        public int IdTowaru { get; set; }

        [Column(Name = "SWWKU")]
        public string Swwku { get; set; }

        [Column(Name = "MARKER1")]
        public int Marker1 { get; set; }

        [Column(Name = "ID_FAKTURY")]
        public int? ID_FAKTURY { get; set; } = 0;  // UWAGA to klucz obcy do tabeli FAKTURY_POZYCJE

        [Column(Name = "KONTO_WN")]
        public string KontoWn { get; set; }

        [Column(Name = "KONTO_MA")]
        public string KontoMa { get; set; }

        [Column(Name = "ZERO_KRAJ")]
        public int ZeroKraj { get; set; }

        [Column(Name = "UWAGI")]
        public string Uwagi { get; set; }

        [Column(Name = "SKASOWAL")]
        public string Skasowal { get; set; }

        [Column(Name = "IDCENNIKA")]
        public int? IdCennika { get; set; }

        [Column(Name = "IDOPIS")]
        public int? IdOpis = 0;

        [Column(Name = "CZY_FRACHT")]
        public int CzyFracht = 0;

        [Column(Name = "OPIS_ANG")]
        public string OpisAng { get; set; }

        [Column(Name = "IDZLECENIA")]
        public int? IdZlecenia { get; set; } = 0;

        [Column(Name = "CZY_TONY")]
        public int CzyTony { get; set; } = 0;

        [Column(Name = "KWOTA_PLN")]
        public double? KWOTA_PLN { get; set; } // uwaga kwota_PL ???? zdoblowane kwota_W_PLN

        [Column(Name = "KURS_WALUTY")]
        public double? KURS_WALUTY { get; set; }

        [Column(Name = "KURS")]
        public double? KURS { get; set; }


        [Column(Name = "IDTABELI")]
        public int? IDTABELI { get; set; } = 0;


    }
}
