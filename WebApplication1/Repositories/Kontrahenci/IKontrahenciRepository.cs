using WebApplication1.Repositories.Kontrahenci.DTO;
using WebApplication1.Repositories.Kontrahenci.Queries;
using WebApplication1.Tools;

namespace WebApplication1.Repositories.Kontrahenci
{
    public interface IKontrahenciRepository
    {
        Task<Result<KontrahenciList_Dto>> Get_Konntrahenci_List_Async(Get_kontrahenci_Query query);
    }
}
