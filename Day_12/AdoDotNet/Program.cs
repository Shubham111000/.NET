using Microsoft.Extensions.Configuration;

namespace CA_ADO_01
{
    internal class Program
    {
        private static IConfiguration _iconfiguration;
        static void Main(string[] args)
        {
            GetAppSettingsFile();
            PrintProduct();
        }
        static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("Appsettings.json", optional: false, reloadOnChange: true);
            _iconfiguration = builder.Build();
        }
        static void PrintProduct()
        {
            Productlayer obj = new Productlayer(_iconfiguration);
            obj.Products();

            
        }
    }

}