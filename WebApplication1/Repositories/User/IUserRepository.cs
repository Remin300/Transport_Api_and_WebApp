using WebApplication1.Obiekty_ORM.ObiektyORMLinq2DB.Urzytkownicy;
using WebApplication1.Repositories.User.DTO;
using WebApplication1.Repositories.User.Queries;
using WebApplication1.Repositories.Zlecenia.DTO;
using WebApplication1.Tools;

namespace WebApplication1.Repositories.User
{
    public interface IUserRepository
    {
        Task<Login_User_Response_Dto?> LoginAsync(string login, string password);
        Task<GetAppCache_Dto?> GetAppCache(int userId);
        Task<Result<Update_User_DTO>> GetByIdAsync(int userId);
        Task<Result> Update_User_Basic_Info_Async(int userId, Update_User_DTO body);
        Task<Result> Update_User_Pass_Async(int userId, Update_User_Pass_Dto body);

        Task<Result<User_List_Response_Dto>> Get_User_List(int userId, Get_User_List_Query query);

        Task<Result<GetAllUserInfo_Dto>> GetAllInfoByIdAsync(int userId);
        Task<Result> Update_User_All_Info_Async(int userId, int id, Update_User_AllInfo_DTO body);
        Task<Result> Reset_User_Pass_Async(int userId, int id, string newPass);
        Task<Result> Delete_User_async(int id, int userId);
        Task<Result<int>> Create_User_Async(Create_User_Dto body);
    }
}
