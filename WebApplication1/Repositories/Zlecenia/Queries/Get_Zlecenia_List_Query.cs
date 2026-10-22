namespace WebApplication1.Repositories.Zlecenia.Queries
{
    public class Get_Zlecenia_List_Query
    {
        public int PageNo { get; set; }
        public string? Zleceniodawca { get; set; }
        public string? NrReferencyjny { get; set; }
        public string? Przewoznik { get; set; }
        public string? NrRej { get; set; }
        public string? NrZlecenia { get; set; }
        public string? NrFaktury { get; set; }
        public string? Kierowca { get; set; }
        public string? MiejsceZaladunku { get; set; }
        public string? MiejsceRozladunku { get; set; }

        public int? IdUser { get; set; }
        public int? IdDzial { get; set; }
        public int? IdDodatkowyFiltr { get; set; }
        public int? Status { get; set; }
        public int? FiltrDataRodzaj { get; set; } // 1. Data zlecenia ; 2.Data załadunku ; 3.Data rozładunku ; 4.Data zafakturowania ;
        public DateTime? DataOd { get; set; } 
        public DateTime? DataDo { get; set; }

        public int? Transport_0_Spedycja_1 { get; set; }

    }
}
