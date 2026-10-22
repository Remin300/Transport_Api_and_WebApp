namespace WebApplication1.Repositories.User.DTO
{
    public class Login_User_Response_Dto
    {
        public int id { get; set; }
        public string token { get; set; }

        public string username { get; set; }

        public List<int>? dostepneOddzialy { get; set; }
        public List<int>? dostepneFiltry { get; set; }
    }
}
