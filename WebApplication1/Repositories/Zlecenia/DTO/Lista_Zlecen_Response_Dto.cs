using WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja.Views;

namespace WebApplication1.Repositories.Zlecenia.DTO
{
    public class Lista_Zlecen_Response_Dto
    {
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
        public int PageNo { get; set; }
        public List<VZleceniaSpedNew_ORM> ListaZlecen { get; set; }
    }
}
