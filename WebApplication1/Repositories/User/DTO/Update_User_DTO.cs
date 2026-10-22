using LinqToDB.Mapping;

namespace WebApplication1.Repositories.User.DTO
{
    public class Update_User_DTO
    {
        public string? LOGIN { get; set; }
        public string? IMIE { get; set; }
        public string? NAZWISKO { get; set; }
        public string? ADRES { get; set; }
        public string? MIASTO { get; set; }

    }
}
