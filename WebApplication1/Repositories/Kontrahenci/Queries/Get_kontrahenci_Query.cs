namespace WebApplication1.Repositories.Kontrahenci.Queries
{
    public class Get_kontrahenci_Query
    {
        public int PageNo { get; set; }

        public string? nip { get; set; }
        public string? nazwa { get; set; }

        public bool? aktywny { get; set; }

    }
}
