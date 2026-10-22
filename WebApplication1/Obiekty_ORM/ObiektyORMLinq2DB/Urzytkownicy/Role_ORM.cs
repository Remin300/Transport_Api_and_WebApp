using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Urzytkownicy
{
    [Table(Name = "ROLE")]
    internal class Role_ORM
    {
        [PrimaryKey, NotNull, Column(Name = "ID")]
        public int Id { get; set; }

        [Column(Name = "NAZWA"), NotNull]
        public string Nazwa { get; set; } = null!;
    }
}
