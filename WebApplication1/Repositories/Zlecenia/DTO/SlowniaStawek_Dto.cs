

namespace WebApplication1.Repositories.Zlecenia.DTO
{
    public class SlowniaStawek_Dto
    {
    
        public int? Id{ get; set; }
        public string? nazwa { get; set; }
        public double? DefaultKwota { get; set; }
        public int? IdDefaultVat { get; set; }
        public int? IdDefaultJednostkaMiar { get; set; }
        public int? IdDefaultWaluta { get; set; }
    }
}
