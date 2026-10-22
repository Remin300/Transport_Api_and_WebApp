using WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja;
using WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja.Views;
using WebApplication1.Repositories.Zlecenia.DTO;
using WebApplication1.Repositories.Zlecenia.Helpers;
using WebApplication1.Repositories.Zlecenia.Queries;
using WebApplication1.Tools;

namespace WebApplication1.Repositories.Zlecenia
{
    public interface IZlecenia_Repository
    {

        Task<Result<Lista_Zlecen_Response_Dto>> Get_Zlecenia_List_Async(Get_Zlecenia_List_Query query, int userId);
        Task<Result<Ladunek_Zbiorowy_Response_Dto>> Get_Ladunek_Zbiorowy_Async(int zleceni_id);
        
        // ==== ZLECENIA ========================================
        Task<Result<GetZlecenieToEdit_Dto>> Get_Zlecenie_ById_Async(int id_zlecenia);
        Task<Result<int>> Create_Zlecenia_Async(Update_Zlecenie_Dto create_dto);
        Task<Result> Edit_Zlecenia_Async(int idZlec, Update_Zlecenie_Dto update_dto);
        Task<Result> Delete_Zlecenia_Async(int id_zlecenia, int userId);
        // ======================================================


        // ==== TOWARY ==========================================
        Task<Result<Update_Towar_Dto>> Get_Towar_Async(int id_Towaru);
        Task<Result<int>> Create_Towar_Async(Update_Towar_Dto update_dto);
        Task<Result> Update_Towar_Async(Update_Towar_Dto update_dto);
        Task<Result> Delete_Towar_Async(int id_towaru, int userId);
        // ======================================================


        // ==== STAWKI WLASNE =================================== 
        Task<Result<Update_Stawka_Wlasna_Dto>> Get_Stawka_Wlasna_Async(int id_Stawki);
        Task<Result<int>> Create_Stawka_Wlasna_Async(Update_Stawka_Wlasna_Dto update_dto);
        Task<Result> Update_Stawka_Wlasna_Async(Update_Stawka_Wlasna_Dto update_dto);
        Task<Result> Delete_Stawka_Wlasna_Async(int id_Stawki, int userId);
        // ======================================================


        // ==== STAWKI KOSZTOWE =================================
        Task<Result<Update_Stawka_Kosztowa_Dto>> Get_Stawka_Kosztowa_Async(int id_Stawki);
        Task<Result<int>> Create_Stawka_Kosztowa_Async(Update_Stawka_Kosztowa_Dto update_dto);
        Task<Result> Update_Stawka_Kosztowa_Async(Update_Stawka_Kosztowa_Dto update_dto);
        Task<Result> Delete_Stawka_Kosztow_Async(int id_Stawki, int userId);
        // ======================================================




        Task<Lista_Dane_do_kontrolek_Dto> Get_datne_dodatkowe();
    }
}
