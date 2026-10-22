using LinqToDB;
using WebApplication1.ObiektyORMLinq2DB;
using WebApplication1.Repositories.Kontrahenci.DTO;
using WebApplication1.Repositories.Kontrahenci.Queries;
using WebApplication1.Tools;

namespace WebApplication1.Repositories.Kontrahenci
{
    public class KontrahenciRepository : IKontrahenciRepository
    {
        public async Task<Result<KontrahenciList_Dto>> Get_Konntrahenci_List_Async(Get_kontrahenci_Query query)
        {
            try
            {

                // baza danych ma problem z dłużycm zapytaniem. Czasamu User lubi dodać PL lub - w filtrze
                query.nip = (query.nip ?? "").Trim();

                if (query.nip.Length > 10)
                {
                    query.nip = query.nip.Substring(0, 10);
                }



                using (var dbConnection = DbConnectionLinq2DB.GetConnection())
                {

                    var filteredList = dbConnection.GetTable<Kontrahenci_ORM>().AsQueryable()
                         .Where(k =>
                                k.NAZWA.Trim().ToLower().Contains(query.nazwa.Trim().ToLower()) &&
                                k.NIP.Trim().Contains(query.nip));


                    if (query.aktywny.HasValue && query.aktywny == true)
                    {
                        filteredList = filteredList.Where(x => x.AKTYWNY == 1);
                    }
                    else
                    {
                        filteredList = filteredList.Where(x => x.AKTYWNY == 0);
                    }


                    // Łączna liczba wyników — oddzielne zapytanie COUNT
                    int itemsPerPage = 50;
                    var totalItems = filteredList.Count();
                    var totalPages = (int)Math.Ceiling(totalItems / (double)itemsPerPage);
                    int offset = (query.PageNo - 1) * itemsPerPage;


                    // rzutowanie na liste
                    var finalList = filteredList
                        .Select(x => new Kontrahent_Dto
                        {
                            id = x.ID_KONTRAHENTA,
                            nazwa = x.NAZWA,
                            nip = x.NIP
                        })
                         .OrderBy(x => x.nazwa)
                         .Skip(offset)
                         .Take(itemsPerPage)
                         .ToList();



                    var response = new KontrahenciList_Dto
                    {
                        TotalItems = totalItems,
                        TotalPages = totalPages,
                        PageNo = query.PageNo,
                        kontrahenci = finalList
                    };



                    return Result<KontrahenciList_Dto>.Ok(response);

                }
            }
            catch (Exception ex)
            {
                return Result<KontrahenciList_Dto>.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);

            }
        }

    }
}
