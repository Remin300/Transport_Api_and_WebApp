using WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja.Views;

namespace WebApplication1.Repositories.User.DTO
{
    public class User_List_Response_Dto
    {
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
        public int PageNo { get; set; }
        public List<User_Dto>? UserList { get; set; }
    }
}
