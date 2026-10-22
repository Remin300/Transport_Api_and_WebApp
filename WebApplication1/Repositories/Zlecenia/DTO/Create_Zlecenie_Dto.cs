namespace WebApplication1.Repositories.Zlecenia.DTO
{
    public class Create_Zlecenie_Dto
    {
        public string? NumerPelny { get; set; }
        public int? IdZleceniodawcy { get; set; }
        public int? IdWykonawcy { get; set; }

        public string? zleceniodawcaNazwa { get; set; }
        public string? wykonawcaNazwa { get; set; }

        public DateTime? DataZlecenia { get; set; }
        public DateTime? DataZaladunku { get; set; }
        public DateTime? DataRozladunku { get; set; }


        public string? RejPojazduObcego { get; set; }  // IDPOJAZD
        public string? RejNaczepyObcej { get; set; }
        public string? KierowcaObcy { get; set; }   // IDKIEROWCA
        public string? ZmiennikObcy { get; set; }



        public string? WarunkiDodatkowe { get; set; }
        public int? IdUser { get; set; }


        // =============================================
        // ======== Towar / koszr/ stawka ==============
        // =============================================
        public int? towar_id { get; set; }
        public string? towar_nazwa { get; set; }
        public double? towar_ilosc { get; set; }
        public float? towar_wartosc { get; set; }
        public int? towar_idwaluty { get; set; }


        public int? sw_id { get; set; }
        public int? sw_slownik_id { get; set; }
        public double? StawkaWlasna { get; set; }
        public int? IdWalutySw { get; set; }
        public int? IdTabeliSw { get; set; }
        public int? IdVatSw { get; set; } = 0;


        public int? ps_id { get; set; }
        public int? ps_slownik_id { get; set; }
        public double? PrzewoznikStawka { get; set; }
        public int? IdWalutyPs { get; set; }
        public int? IdTabeliPs { get; set; }
        public int? IdVatPs { get; set; } = 0;

        // =============================================
        // =============================================



        public int? IdKategoria { get; set; }   // powiązanie z tabelą "ODDZIAŁY"
        public string? DodatkowyOpisLadunku { get; set; }
        public string? TrasaOd { get; set; }
        public string? TrasaDo { get; set; }


        public int? Finalized { get; set; } = 0;   // 0 - otwarte;  1 - w trakcie fakturowania;  2 - zafakturowane;  3 - do wyjasnienia;   4 - zamkniete

        public int? FILTR1 { get; set; }     // to pole przechowuje id do rekordu z tabeli "FILTRY_PRZYCH"}
        public string? ZLADAUNEK0 { get; set; }
        public string? WYLADUNEK0 { get; set; }
    }
}
