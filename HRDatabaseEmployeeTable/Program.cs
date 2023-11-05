using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace HRDatabaseEmployeeTable
{
    internal class Program
    {
        private static IConfiguration _iconfiguration;

        public static void Main()
        {
            GetAppsettingsFile();
            ShowTable();
            Update();
            ShowTable();
            Insert();
            ShowTable();
            Delete();
            ShowTable() ;


        }
        static void GetAppsettingsFile() 
        {
            var builder= new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("Appsettings.json",optional:false,reloadOnChange:true);
            _iconfiguration= builder.Build();
        }
        static void Insert() 
        {
            StronglyType Strobj = new StronglyType(_iconfiguration);
            Strobj.Insert_Employee(new Employee{ Name="Akshay",Salary
            =55000,Gender='M',Address="Kolhapur",Id=2});
        }
        static void ShowTable() 
        {
            StronglyType Strobj = new StronglyType(_iconfiguration);
            Strobj.Show_Table();

        }
        static void Delete() 
        {
            StronglyType Strobj = new StronglyType(_iconfiguration);
            Strobj.Delete(2);
        }
        static void Update() 
        {
            StronglyType Strobj = new StronglyType(_iconfiguration);
            Strobj.Update_Employee(new Employee
            {
                Name = "Akshay",Salary= 55000,Gender = 'M',Address = "Kolhapur",Id = 4
            },6);
        }

    }
}
