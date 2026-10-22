using LinqToDB;
using WebApplication1.ObiektyORMLinq2DB.TS;

namespace WebApplication1.Tools
{
    public static class Config_Table_Helper
    {
        //  UWAGA *->     PRAWDOPODOBNIE JAKO VAR DO ZROBIENIA JEDNĄ FUNKCJĄ LUB JAKO PRZECIĄŻENIE 
        public static int GetValueToInt(string _pole = "") // wyciaganie danych z tabeli konfiguracja => IDWłaściciela
        {
            int _ret = 0;
            KONFIGURACJA_ORM GetKONFIGURACJA_ORM = new KONFIGURACJA_ORM();

            using (var dbConnection = DbConnectionLinq2DB.GetConnection())
            {
                GetKONFIGURACJA_ORM = dbConnection.GetTable<KONFIGURACJA_ORM>()
                             .FirstOrDefault(x => x.POLE == _pole);
            }
            if (GetKONFIGURACJA_ORM == null)
            { _ret = 0; }
            else
            { _ret = GetKONFIGURACJA_ORM.VALUE_INT; }
            return _ret;
        }
        public static string GetValueToString(string _pole) // wyciaganie danych z tabeli konfiguracja => IDWłaściciela
        {
            KONFIGURACJA_ORM GetKONFIGURACJA_ORM = new KONFIGURACJA_ORM();
            using (var dbConnection = DbConnectionLinq2DB.GetConnection())
            {
                GetKONFIGURACJA_ORM = dbConnection.GetTable<KONFIGURACJA_ORM>()
                             .FirstOrDefault(x => x.POLE == _pole);
            }
            if (GetKONFIGURACJA_ORM != null)
            {
                return GetKONFIGURACJA_ORM.VALUE_STRING;
            }
            else
            {
                return "";
            }
        }
        public static double GetValueToDouble(string _pole) // wyciaganie danych z tabeli konfiguracja => IDWłaściciela
        {
            KONFIGURACJA_ORM GetKONFIGURACJA_ORM = new KONFIGURACJA_ORM();
            using (var dbConnection = DbConnectionLinq2DB.GetConnection())
            {
                GetKONFIGURACJA_ORM = dbConnection.GetTable<KONFIGURACJA_ORM>().Where(x => x.POLE == _pole)
                             .FirstOrDefault();
            }
            if (GetKONFIGURACJA_ORM != null)
            { return GetKONFIGURACJA_ORM.VALUE_FLOAT; }
            else { return 0; }
        }
        public static DateTime? GetValueToDateString(string _pole) // UWAGA *->   niezrobione poprawnie UWAGA DO POPRAWY DATA CIĄGNIĘTA JAKO STRING ????
        {
            KONFIGURACJA_ORM GetKONFIGURACJA_ORM = new KONFIGURACJA_ORM();
            using (var dbConnection = DbConnectionLinq2DB.GetConnection())
            {
                GetKONFIGURACJA_ORM = dbConnection.GetTable<KONFIGURACJA_ORM>()
                    .FirstOrDefault(x => x.POLE == _pole);

                if (GetKONFIGURACJA_ORM == null || GetKONFIGURACJA_ORM.VALUE_DATE == null)
                {
                    return null;
                }
            }
            return GetKONFIGURACJA_ORM.VALUE_DATE;
        }
        //---
        public static void SetValueToInt(string _pole, int _value) // wyciaganie danych z tabeli konfiguracja => IDWłaściciela
        {
            KONFIGURACJA_ORM GetKONFIGURACJA_ORM = new KONFIGURACJA_ORM();
            using (var dbConnection = DbConnectionLinq2DB.GetConnection())
            {
                var KONFIGURACJA_ORM = dbConnection.GetTable<KONFIGURACJA_ORM>().Where(x => x.POLE == _pole)
                              .FirstOrDefault();
                if (KONFIGURACJA_ORM == null)
                {
                    GetKONFIGURACJA_ORM.VALUE_INT = _value;
                    GetKONFIGURACJA_ORM.POLE = _pole;
                    dbConnection.InsertWithIdentity(GetKONFIGURACJA_ORM);
                }
                else
                {
                    KONFIGURACJA_ORM.VALUE_INT = _value;
                    KONFIGURACJA_ORM.VALUE_FLOAT = 0;
                    KONFIGURACJA_ORM.VALUE_STRING = "";
                    dbConnection.Update(KONFIGURACJA_ORM);
                }
            }
        }
        public static void SetValueToString(string _pole, string _value) // wyciaganie danych z tabeli konfiguracja => IDWłaściciela
        {
            KONFIGURACJA_ORM GetKONFIGURACJA_ORM = new KONFIGURACJA_ORM();
            using (var dbConnection = DbConnectionLinq2DB.GetConnection())
            {
                var KONFIGURACJA_ORM = dbConnection.GetTable<KONFIGURACJA_ORM>()
                                    .FirstOrDefault(x => x.POLE == _pole);
                if (KONFIGURACJA_ORM == null)
                {
                    GetKONFIGURACJA_ORM.VALUE_STRING = _value;
                    GetKONFIGURACJA_ORM.POLE = _pole;
                    dbConnection.InsertWithIdentity(GetKONFIGURACJA_ORM);
                }
                else
                {
                    KONFIGURACJA_ORM.VALUE_STRING = _value;
                    dbConnection.Update(KONFIGURACJA_ORM);
                }
            }
        }
        public static void SetValueToDouble(string _pole, double _value) // wyciaganie danych z tabeli konfiguracja => IDWłaściciela
        {
            KONFIGURACJA_ORM GetKONFIGURACJA_ORM = new KONFIGURACJA_ORM();
            using (var dbConnection = DbConnectionLinq2DB.GetConnection())
            {
                var KONFIGURACJA_ORM = dbConnection.GetTable<KONFIGURACJA_ORM>()
                                .FirstOrDefault(x => x.POLE == _pole);
                if (KONFIGURACJA_ORM == null)
                {
                    GetKONFIGURACJA_ORM.VALUE_FLOAT = _value;
                    GetKONFIGURACJA_ORM.POLE = _pole;
                    dbConnection.InsertWithIdentity(GetKONFIGURACJA_ORM);
                }
                else
                {
                    KONFIGURACJA_ORM.VALUE_FLOAT = _value;
                    dbConnection.Update(KONFIGURACJA_ORM);
                }
            }
        }
        public static void SetValueToDate(string _pole, DateTime _value) //UWAGA *->   niezrobione do zrobienia pole mało używane może być do wpisywania
                                                                         // teminu licencji 
        {
            KONFIGURACJA_ORM GetKONFIGURACJA_ORM = new KONFIGURACJA_ORM();
            using (var dbConnection = DbConnectionLinq2DB.GetConnection())
            {
                var KONFIGURACJA_ORM = dbConnection.GetTable<KONFIGURACJA_ORM>()
                                .FirstOrDefault(x => x.POLE == _pole);
                if (KONFIGURACJA_ORM == null)
                {
                    GetKONFIGURACJA_ORM.VALUE_DATE = _value;
                    GetKONFIGURACJA_ORM.POLE = _pole;
                    dbConnection.InsertWithIdentity(GetKONFIGURACJA_ORM);
                }
                else
                {
                    KONFIGURACJA_ORM.VALUE_DATE = _value;
                    dbConnection.Update(KONFIGURACJA_ORM);
                }
            }
        }
    }
}
