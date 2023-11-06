using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Disconnected_Layer
{
    internal class Program
    {
        private static IConfiguration configuration;

        static void Main(string[] args)
        {
            GetAppsettingsFile();
            Getlist();
        }
       static  void GetAppsettingsFile() 
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("Appsettings.json", optional: false, reloadOnChange: true);
            configuration = builder.Build();
        }
        static void Getlist() 
        {
            Strongly_Type type = new Strongly_Type(configuration);
            var dt=type.GetList();
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                    Console.Write(row[col] + " ");
                Console.WriteLine("----------------------------------");

            }

        }
    }
}
