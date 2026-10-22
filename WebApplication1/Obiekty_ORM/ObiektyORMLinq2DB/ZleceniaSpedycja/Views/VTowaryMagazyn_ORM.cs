using LinqToDB.Mapping;
using System;

namespace WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja.Views
{
    [Table(Name = "VMAGAZYN_TOWARY")]
    internal class VTowaryMagazyn_ORM
    {
        [PrimaryKey, Identity]
        [Column("ID_TOWARY_MAGAZYN")]
        public int ID_TOWARY_MAGAZYN { get; set; }

        [Column("ID_ZLECENIA")]
        public int ID_ZLECENIA { get; set; }

        [Column("LP")]
        public int LP { get; set; }

        [Column("DATA_PRZYJECIA")]
        public DateTime DATA_PRZYJECIA { get; set; }

        [Column("DATA_WYDANIA")]
        public DateTime DATA_WYDANIA { get; set; }

        [Column("ID_TOWARY_SRC")]
        public int ID_TOWARY_SRC { get; set; }

        [Column("ID_TOWARY_DST")]
        public int ID_TOWARY_DST { get; set; }

        [Column("WYDANO")]
        public int WYDANO { get; set; }

        [Column("IMPORTER")]
        public string IMPORTER { get; set; }

        [Column("ODBIORCA")]
        public string ODBIORCA { get; set; }

        [Column("EKSPORTER")]
        public string EKSPORTER { get; set; }

        [Column("DOSTAWCA")]
        public string DOSTAWCA { get; set; }

        [Column("TOWAR")]
        public string TOWAR { get; set; }

        [Column("TOWAR_NR")]
        public int TOWAR_NR { get; set; }
    }
}
