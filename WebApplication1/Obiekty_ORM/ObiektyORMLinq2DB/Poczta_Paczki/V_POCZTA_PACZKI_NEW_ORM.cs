using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Poczta_Paczki
{

    [Table(Name = "V_POCZTA_PACZKI_NEW")]
    internal class V_POCZTA_PACZKI_NEW_ORM
    {
        [Column(Name = "ID"), PrimaryKey]
        public int ID { get; set; }

        [Column(Name = "DATA")]
        public DateTime? DATA { get; set; }

        [Column(Name = "ODEB_1_WYSL_2")]
        public int ODEB_1_WYSL_2 { get; set; }

        [Column(Name = "STATUS")]
        public string STATUS { get; set; }

        [Column(Name = "USER_ID")]
        public int? USER_ID { get; set; }

        [Column(Name = "ID_NADAWCA_ODBIORCA")]
        public int? ID_NADAWCA_ODBIORCA { get; set; }

        [Column(Name = "NAZWA_NADAWCA_ODBIORCA")]
        public string NAZWA_NADAWCA_ODBIORCA { get; set; }

        [Column(Name = "LOGIN")]
        public string LOGIN { get; set; }

        [Column(Name = "UWAGI")]
        public string UWAGI { get; set; }
    }
}
