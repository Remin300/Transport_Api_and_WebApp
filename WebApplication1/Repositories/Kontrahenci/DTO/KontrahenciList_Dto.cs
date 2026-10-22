namespace WebApplication1.Repositories.Kontrahenci.DTO
{
    public class KontrahenciList_Dto
    {
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
        public int PageNo { get; set; }
        public List<Kontrahent_Dto>? kontrahenci { get; set; }
    }
}
