using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja
{
    [Table(Name = "TOWARY_KOSZTY")]
    internal class TowaryKoszty_ORM
    {
        [PrimaryKey]
        [Column(Name = "ID_TOWARY_KOSZTY")]
        public int IdTowaryKoszty { get; set; }



        // ----------------------------------------------------------------------------------------------------
        // ----------                                                                  ------------------------
        // ----------             !!!!!!!!!!!!!    UWAGA  !!!!!!!!!                    ------------------------
        // ----------                          dwa id zlecenia                         ------------------------
        // ----------                                                                  ------------------------
        // ----------------------------------------------------------------------------------------------------

        [Column(Name = "ID_ZLECENIA")]
        public int? IdZlecenia { get; set; }

        [Column(Name = "ID_ZLECENIA_SPED")]
        public int? IdZleceniaSped { get; set; }


        // ----------------------------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------------



        [Column(Name = "IDKOSZTU")]
        public int? IdKosztu { get; set; }

        [Column(Name = "OPIS")]
        public string Opis { get; set; }

        [Column(Name = "KWOTA_W_WALUCIE")]
        public double? KwotaWWalucie { get; set; }

        [Column(Name = "IDWALUTY")]
        public int? IdWaluty { get; set; }

        [Column(Name = "IDVAT")]
        public int? IdVat { get; set; }

        //[Column(Name = "ID_KONTA")]
        //public int? ID_KONTA { get; set; }


        [Column(Name = "ILOSC")]
        public double? Ilosc { get; set; }

        [Column(Name = "IDJEDNOSTKA_MIAR")]
        public int? IdJednostkaMiar { get; set; }

        [Column(Name = "IDTOWARU")]
        public int? IdTowaru { get; set; }

        [Column(Name = "ID_KONTRAHENTA")]
        public int? IdKontrahenta { get; set; }


        [Column(Name = "DATA_OTRZYMANIA")]
        public DateTime? DataOtrzymania { get; set; }

        [Column(Name = "DATA_ZAPLATY")]
        public DateTime? DataZaplaty { get; set; }

        [Column(Name = "DATA_WYSTAWIENIA")]
        public DateTime? DATA_WYSTAWIENIA { get; set; }

        [Column(Name = "DATA_SPRZEDAZY")]
        public DateTime? DATA_SPRZEDAZY { get; set; }

        [Column(Name = "PLATNE_DO")]
        public DateTime? PLATNE_DO { get; set; }  // Uwaga nieintuicyjna nazwa --> to jest data otrzymania Faktury (samej faktury bez reszcty dokumentow )


        [Column(Name = "NR_FAKTURY")]
        public string NrFaktury { get; set; }

        [Column(Name = "UWAGI")]
        public string Uwagi { get; set; }

        [Column(Name = "SKASOWAL")]
        public string Skasowal { get; set; }

        [Column(Name = "ZAPLACONE")]
        public int? Zaplacone { get; set; }

        [Column(Name = "ID_TABELA")]
        public int? IdTabela { get; set; }

        [Column(Name = "NETTO")]
        public double? NETTO { get; set; }

        [Column(Name = "BRUTTO")]
        public double? BRUTTO { get; set; }

        [Column(Name = "KWOTAVATPLN")]
        public double? KWOTAVATPLN { get; set; }

        [Column(Name = "VAT")]
        public double? Vat { get; set; }

        [Column(Name = "ID_KONTA")]
        public int? IdKonta { get; set; }

        [Column(Name = "C_JEDNPLN")]
        public double? C_JEDNPLN { get; set; }

        [Column(Name = "C_JEDNEURO")] // przechowywana stara wartośc stawki przed wgraniem KSEF
        public double? C_JEDNEURO { get; set; }

        [Column(Name = "KWOTA_W_PLN")]
        public double? KWOTA_W_PLN { get; set; }

        [Column(Name = "KURS_WALUTY")]
        public double? KURS_WALUTY { get; set; }
        [Column(Name = "IL_DNI_PLATNOSCI")]
        public int? IL_DNI_PLATNOSCI { get; set; }
        [Column(Name = "IDDOKUMENT")]
        public int? IDDOKUMENT { get; set; }
        [Column(Name = "VAT_PLN")]
        public int? VAT_PLN { get; set; }

        [Column(Name = "UWAGI1")]
        public string UWAGI1 { get; set; }

        [Column(Name = "UWAGI2")]
        public string UWAGI2 { get; set; }

        [Column(Name = "REZERWA")]
        public int? REZERWA { get; set; }


    }
}
