using System.Configuration;

namespace RestaurantManagement.Utilities
{
    /// <summary>
    /// Ndihmues për konfigurimin
    /// </summary>
    public static class ConfigHelper
    {
        /// <summary>
        /// Marrë nënshtresen e lidhjes
        /// </summary>
        public static string GetConnectionString(string name = "DefaultConnection")
        {
            return ConfigurationManager.ConnectionStrings[name]?.ConnectionString 
                ?? "Server=(localdb)\\mssqllocaldb;Database=RestaurantDB;Trusted_Connection=true;";
        }

        /// <summary>
        /// Marrë vlerën e cilësimit
        /// </summary>
        public static string GetAppSetting(string key, string defaultValue = "")
        {
            return ConfigurationManager.AppSettings[key] ?? defaultValue;
        }

        /// <summary>
        /// Emri i aplikacionit
        /// </summary>
        public static string AppName => GetAppSetting("AppName", "Restaurant Management System");

        /// <summary>
        /// Emri i kompanisë
        /// </summary>
        public static string CompanyName => GetAppSetting("CompanyName", "Your Restaurant");

        /// <summary>
        /// Versioni
        /// </summary>
        public static string Version => GetAppSetting("Version", "1.0.0");
    }
}
