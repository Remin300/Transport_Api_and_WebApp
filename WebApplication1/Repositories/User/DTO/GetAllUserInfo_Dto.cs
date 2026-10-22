namespace WebApplication1.Repositories.User.DTO
{
    public class GetAllUserInfo_Dto
    {
        public Update_User_AllInfo_DTO user { get; set; }
        public List<AppCacheSelectOption_Dto> Dzialy { get; set; }
        public List<AppCacheSelectOption_Dto> Filtry { get; set; }
    }
}
