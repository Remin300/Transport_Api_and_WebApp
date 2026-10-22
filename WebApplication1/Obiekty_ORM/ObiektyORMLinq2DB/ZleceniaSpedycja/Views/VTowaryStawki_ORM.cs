using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja.Views
{
    [Table(Name = "VTOWARY_STAWKINEW")]
    internal class VTowaryStawki_ORM
    {
        [Column(Name = "ID_TOWARY_STAWKI")]
        public int IdTowaryStawki { get; set; }

        [Column(Name = "IDTOWARU")]
        public int IdTowaru { get; set; }

        [Column(Name = "TRASA")]
        public string TRASA { get; set; }

        [Column(Name = "OPIS")]
        public string Opis { get; set; }

        [Column(Name = "KWOTA_W_WALUCIE")]
        public double KwotaWWalucie { get; set; }

        [Column(Name = "KWOTA_W_PLN")]
        public double KWOTA_W_PLN { get; set; }

        [Column(Name = "WALUTA")]
        public string Waluta { get; set; }

        [Column(Name = "VAT")]
        public string Vat { get; set; }

        [Column(Name = "ILOSC")]
        public double Ilosc { get; set; }

        [Column(Name = "JM")]
        public string JednostkaMiary { get; set; }

        [Column(Name = "IDWALUTY")]
        public int IdWaluty { get; set; }

        [Column(Name = "SWWKU")]
        public string Swwku { get; set; }

        [Column(Name = "MARKER1")]
        public int Marker1 { get; set; }

        [Column(Name = "ID_FAKTURY")] //
        public int IdFaktury { get; set; }

        [Column(Name = "NUMER_FAKTURY")]
        public string Numer_Faktury { get; set; }


        [Column(Name = "IDFAKTURY_POZYCJE")]
        public int IdFakturyPozycje { get; set; }  

        [Column(Name = "SKATEGORIA")]
        public int Skategoria { get; set; }

        [Column(Name = "UWAGI")]
        public string Uwagi { get; set; }

        [Column(Name = "NUMER_ZLECENIA")]
        public string NUMER_ZLECENIA { get; set; }

        [Column(Name = "IDJEDNOSTKA_MIAR")]
        public int IDJEDNOSTKA_MIAR { get; set; }
        [Column(Name = "IDZLECENIA")]
        public int IDZLECENIA { get; set; }
        [Column(Name = "ID_KONTRAHENTA")]
        public int ID_KONTRAHENTA { get; set; }
        [Column(Name = "TOWAR_NR")]
        public int TOWAR_NR { get; set; }
        [Column(Name = "IDVAT")]
        public int IDVAT { get; set; }
        [Column(Name = "DATA_ZALADUNKU")] 
        public DateTime? DATA_ZALADUNKU { get; set; }
        [Column(Name = "DATA_ROZLADUNKU")]
        public DateTime? DATA_ROZLADUNKU { get; set; }

        [Column(Name = "NUMER7")]
        public string NUMER7 { get; set; }

        [Column(Name = "NR_REJ")]
        public string NR_REJ { get; set; }
        [Column(Name = "NACZEPA")]
        public string NACZEPA { get; set; }
        [Column(Name = "TOWAR")]
        public string TOWAR { get; set; }

        [Column(Name = "ILOSCTOW")]
        public string ILOSCTOW { get; set; }

        [Column(Name = "METRY3")]
        public double METRY3 { get; set; }

        [Column(Name = "ILOSC_OBL")]
        public double ILOSC_OBL { get; set; }

        [Column(Name = "SZTUKI")]
        public double SZTUKI { get; set; }
        [Column(Name = "TABELA")]
        public string TABELA { get; set; }
        [Column(Name = "KURS")]
        public double KURS { get; set; }
      //  [Column(Name = "NAZWA_TOWARU")]
     //   public string NAZWA_TOWARU { get; set; }

        

    }
}
