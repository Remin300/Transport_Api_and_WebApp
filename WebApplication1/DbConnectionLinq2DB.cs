using LinqToDB.Configuration;
using LinqToDB.Data;

namespace WebApplication1
{
    public static class DbConnectionLinq2DB
    {
        public static string _connectionString
        {
            get
            {
                return $"User=SYSDBA;Password=masterkey;Database={AppConfig.DatabasePath} ;Port=3050; Charset=NONE ";
            }
        }


        // Domyślna konfiguracja dostawcy
        static DbConnectionLinq2DB()
        {
            // Rejestracja ustawień dla LINQ to DB
            DataConnection.DefaultSettings = new LinqToDbSettings();
        }

        // Metoda do tworzenia nowego połączenia
        public static DataConnection GetConnection()
        {
            return new DataConnection("Firebird", _connectionString);
        }
        public static void CloseConnection(DataConnection connection)
        {
            if (connection != null)
            {
                connection.Close();  // Zamknij połączenie
            }
        }
    }

    // Klasa konfiguracji LINQ to DB
    public class LinqToDbSettings : ILinqToDBSettings
    {
        public IEnumerable<IDataProviderSettings> DataProviders => Enumerable.Empty<IDataProviderSettings>();

        public string DefaultConfiguration => "Firebird";
        public string DefaultDataProvider => "Firebird";

        public IEnumerable<IConnectionStringSettings> ConnectionStrings
        {
            get
            {
                yield return new ConnectionStringSettings
                {
                    Name = "Firebird",
                    ProviderName = "Firebird",
                    ConnectionString = DbConnectionLinq2DB._connectionString
                };
            }
        }
    }

    // Klasa definiująca ustawienia łańcucha połączenia
    public class ConnectionStringSettings : IConnectionStringSettings
    {
        public string ConnectionString { get; set; }
        public string Name { get; set; }
        public string ProviderName { get; set; }
        public bool IsGlobal => false;
    }



    public static class AppConfig
    {
        private static Dictionary<string, string> _configValues;

        static AppConfig()
        {
            LoadConfig();
        }

        private static void LoadConfig()
        {
            string configFilePath = "ProgramConfig.txt";

            if (!File.Exists(configFilePath))
                throw new FileNotFoundException("Nie znaleziono pliku konfiguracyjnego: ProgramConfig.txt");

            _configValues = File.ReadAllLines(configFilePath)
                .Where(line => !string.IsNullOrWhiteSpace(line) && line.Contains('='))
                .Select(line =>
                {
                    var parts = line.Split(new[] { '=' }, 2);
                    return new KeyValuePair<string, string>(parts[0].Trim(), parts[1].Trim());
                })
                .ToDictionary(kv => kv.Key, kv => kv.Value);
        }

        public static string GetValue(string key)
        {
            return _configValues.ContainsKey(key) ? _configValues[key] : null;
        }

        public static string DatabasePath => GetValue("db_path");
        public static string FilesPath => GetValue("files_path");
    }



}