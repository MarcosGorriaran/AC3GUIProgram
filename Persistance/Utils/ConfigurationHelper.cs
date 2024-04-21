using Microsoft.Extensions.Configuration;

namespace AC3GUIProgram.Persistance.Utils
{
    public static class ConfigurationHelper
    {
        const string ConfFilePath = "appsettings.json";
        const string DBConnStringDataName = "MyPostgresConn";
        public static string GetConnectionString()
        {
            // Carregar la cadena de connexió a la base de dades des de l'arxiu de configuració
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(ConfFilePath, optional: false, reloadOnChange: true)
                .Build();

            return config.GetConnectionString(DBConnStringDataName)??"";
        }
    }
}
