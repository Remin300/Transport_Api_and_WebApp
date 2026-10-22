namespace WebApplication1.ObiektyORMLinq2DB.DaneFirmy.DrukiPDF
{
    public class CompanyInfo
    {
        public string Nazwa { get; set; }
        public string Addres { get; set; }
        public string Kod { get; set; }
        public string Miasto { get; set; }
        public string NIP { get; set; }
        public string Tel { get; set; }
        //  public string Fax { get; set; }
    }

    public class Nazwa_JPG_Z_Logo
    {
        public string Nazwa { get; set; }
    }

    public class WarunekUmowy
    {
        public int Numer { get; set; }
        public string Tresc { get; set; }
    }

    public class WarunekUmowy_EN
    {
        public int Numer { get; set; }
        public string Tresc { get; set; }
    }

    public class Fakturowanie_BURIAN
    {
        public int Numer { get; set; }
        public string Tresc { get; set; }
    }

    public class WarunkiWykonaniaZlecenia_BURIAN
    {
        public int Numer { get; set; }
        public string Tresc { get; set; }
    }



    public class RootObject
    {
        public CompanyInfo CompanyInfo { get; set; }
        public Nazwa_JPG_Z_Logo Nazwa_JPG_Z_Logo { get; set; }
        public List<WarunekUmowy> WarunkiUmowy { get; set; }
        public List<WarunekUmowy_EN> WarunkiUmowy_EN { get; set; }

        public List<Fakturowanie_BURIAN> Fakturowanie_Burian { get; set; }
        public List<WarunkiWykonaniaZlecenia_BURIAN> WarunkiUmowy_Burian { get; set; }
    }
}
