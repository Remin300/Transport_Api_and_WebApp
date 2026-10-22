using LinqToDB;
using LinqToDB.Data;
using System.Globalization;
using System.Text;
using WebApplication1.ObiektyORMLinq2DB.TS;
using WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja;

namespace WebApplication1.Tools
{
    public static class Generators
    {
        public static (string? Nr_Pelny, int? Nr_Kolejny) Generuj_Numer_Zlecenia(int? id_wykonawcy, DateTime? data_zlecenia)
        {
            string numerPelny = "";
            int nr_Kolejny = 0;

            try
            {
                using (var dbConnection = DbConnectionLinq2DB.GetConnection())
                {
                    int maxNrKolejny = 0;


                    // defaultowa maska dla zlecen
                    string maska = "%#####;/;%R";
                    // Ustawianie numeru pełnego
                    int currentYear = data_zlecenia.Value.Date.Year;


                    // oddzielnie transport / spedycja 
                    if (Config_Table_Helper.GetValueToInt("NumeracjaZlecen") == 1)
                    {
                        if (id_wykonawcy == Config_Table_Helper.GetValueToInt("IDWłaściciela"))
                        {
                            if (Config_Table_Helper.GetValueToString("ZlecTransMaska") != "")
                                maska = Config_Table_Helper.GetValueToString("ZlecTransMaska");
                        }
                        else
                        {
                            if (Config_Table_Helper.GetValueToString("ZlecSpedMaska") != "")
                            { maska = Config_Table_Helper.GetValueToString("ZlecSpedMaska"); }
                        }
                    }
                    else  // standardowa maska 
                    {
                        if (Config_Table_Helper.GetValueToString("ZlecTransMaska") != "")
                        { maska = Config_Table_Helper.GetValueToString("ZlecTransMaska"); }
                    }



                    if (Config_Table_Helper.GetValueToInt("Generator") == 1)  // pobierz numer z tabeli
                    {
                        var results = dbConnection.Query<int>(
                            "EXECUTE PROCEDURE GETZLECENIE(@id)",
                            new DataParameter("id", currentYear)
                        ).ToList();
                        maxNrKolejny = results.FirstOrDefault();
                        nr_Kolejny = maxNrKolejny;
                    }
                    else if (Config_Table_Helper.GetValueToInt("Generator") == 2) // generator w kodzie zależny od daty
                    {
                        if (Config_Table_Helper.GetValueToInt("NumeracjaZlecen") == 1)
                        { // oddzielni transport \ spedycja 
                            if (id_wykonawcy == Config_Table_Helper.GetValueToInt("IDWłaściciela"))
                            {
                                maxNrKolejny = dbConnection.GetTable<ZlecenieSped_ORM>()
                                         .Where(x => x.IdWykonawcy == Config_Table_Helper.GetValueToInt("IDWłaściciela") && x.DataZlecenia.Value.Year == currentYear)
                                         .Max(x => (int?)x.NrKolejny) ?? 0;
                            }
                            else
                            {
                                maxNrKolejny = dbConnection.GetTable<ZlecenieSped_ORM>()
                                             .Where(x => x.IdWykonawcy != Config_Table_Helper.GetValueToInt("IDWłaściciela") && x.DataZlecenia.Value.Year == currentYear)
                                             .Max(x => (int?)x.NrKolejny) ?? 0;
                            }
                        }
                        else
                        { // wspólne transport i spedycja
                            maxNrKolejny = dbConnection.GetTable<ZlecenieSped_ORM>()
                                        .Where(x => x.FILTR3 == currentYear)
                                        .Max(x => (int?)x.NrKolejny) ?? 0;
                        }
                        nr_Kolejny = maxNrKolejny + 1;
                    }
                    else if (Config_Table_Helper.GetValueToInt("Generator") == 3) // generator w kodzie nie zalezny od daty
                    {
                        maxNrKolejny = dbConnection.GetTable<ZlecenieSped_ORM>()
                                    .Max(x => (int?)x.NrKolejny) ?? 0;

                        nr_Kolejny = maxNrKolejny + 1;
                    }

                    numerPelny = Generuj_Numer_ZLecenia(maska, nr_Kolejny, DateTime.Now, "");
                }
                return (numerPelny, nr_Kolejny);
            }
            catch (Exception ex)
            {
                return (null, null);
            }
        }

        public static (string? Nr_Pelny, int? Nr_Kolejny) Generuj_Numer_Zlecenia_Burian(int? id_wykonawcy, DateTime? data_zlecenia)
        {
            string numerPelny = "";
            int nr_Kolejny = 0;

            try
            {
                using (var dbConnection = DbConnectionLinq2DB.GetConnection())
                {
                    int maxNrKolejny = 0;


                    // defaultowa maska dla zlecen
                    string maska = "%#####;/;%R";
                    // Ustawianie numeru pełnego
                    int currentYear = data_zlecenia.Value.Date.Year;


                    // oddzielnie transport / spedycja 
                    if (Config_Table_Helper.GetValueToInt("NumeracjaZlecen") == 1)
                    {
                        if (id_wykonawcy == Config_Table_Helper.GetValueToInt("IDWłaściciela"))
                        {
                            if (Config_Table_Helper.GetValueToString("ZlecTransMaska") != "")
                                maska = Config_Table_Helper.GetValueToString("ZlecTransMaska");
                        }
                        else
                        {
                            if (Config_Table_Helper.GetValueToString("ZlecSpedMaska") != "")
                            { maska = Config_Table_Helper.GetValueToString("ZlecSpedMaska"); }
                        }
                    }
                    else  // standardowa maska 
                    {
                        if (Config_Table_Helper.GetValueToString("ZlecTransMaska") != "")
                        { maska = Config_Table_Helper.GetValueToString("ZlecTransMaska"); }
                    }


                    var results = dbConnection.Query<int>(
                     "EXECUTE PROCEDURE GETNUMERZLECENIBUR(@id)",
                      new DataParameter("id", currentYear)
                     ).ToList();

                    maxNrKolejny = results.FirstOrDefault();
                    nr_Kolejny = maxNrKolejny;


                    numerPelny = Generuj_Numer_ZLecenia(maska, nr_Kolejny, DateTime.Now, "");
                }
                return (numerPelny, nr_Kolejny);
            }
            catch (System.Exception ex)
            {
                return (null, null);
            }
        }



        public static string Generuj_Numer_ZLecenia(string mask, int number, DateTime date, string text)
        {
            List<string> parts = StrToList(mask);
            StringBuilder result = new StringBuilder();

            foreach (string part in parts)
            {
                if (!part.StartsWith("%"))
                {
                    // Dodajemy separator lub stały tekst, bez żadnej zmiany
                    result.Append(part);
                }
                else
                {
                    char code = part.Length > 1 ? part[1] : '\0';
                    int padLength = part.Length - 1;

                    switch (code)
                    {
                        case '#':
                            // Formatowanie numeru zlecenia - wypełnienie zerami do odpowiedniej długości
                            result.Append(Padl(number.ToString(), padLength, '0'));
                            break;
                        case 's':
                        case 'S':
                            // Pusta spacja
                            result.Append(" ");
                            break;
                        case 'd':
                        case 'D':
                            // Krótkie formatowanie daty (dzień)
                            result.Append(date.ToString("d", CultureInfo.InvariantCulture));
                            break;
                        case 'm':
                            // Miesiąc z wypełnieniem zerami
                            result.Append(Padl(date.Month.ToString(), padLength, '0'));
                            break;
                        case 'M':
                            // Miesiąc zawsze w formacie 2-cyfrowym
                            result.Append(Padl(date.Month.ToString(), 2, '0'));
                            break;
                        case 'R':
                            // Pełny rok
                            result.Append(date.Year.ToString());
                            break;
                        case 'r':
                            // Dwie ostatnie cyfry roku
                            result.Append(date.Year.ToString().Substring(2, 2));
                            break;
                        case 't':
                        case 'T':
                            // Tekst z wypełnieniem
                            result.Append(Padl(text, padLength, ' '));
                            break;
                    }
                }
            }

            return result.ToString();
        }

        private static List<string> StrToList(string mask)
        {
            // Dzielimy maskę na części, ignorując średniki i inne separatory
            List<string> parts = new List<string>();
            var temp = mask.Split(new char[] { ';' }); // Dzielimy maskę na części po średniku

            // Dodajemy każdą część maski do listy
            foreach (var part in temp)
            {
                parts.Add(part.Trim()); // Usuwamy zbędne spacje
            }
            return parts;
        }

        private static string Padl(string input, int totalWidth, char paddingChar)
        {
            // Wypełnia tekst zerami lub spacjami, jeśli jest krótszy niż wymagana długość
            return input.PadLeft(totalWidth, paddingChar);
        }
    }
}
