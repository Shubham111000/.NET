using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create database HR with Table Employee having column name Id,Name, Salary,Gender,Address.
Create Interface IEmployeeRepository with following methods
	 Employee GetEmployee(int Id);
        IEnumerable<Employee> GetAllEmployee();
        Employee Add(Employee employee);
        Employee Update(Employee employeeChanges);
        Employee Delete(int Id);
Create class which will implement IEmployeeRepository.
In entry class call the method and complete CRUD
Refer next slide for reference


*/
namespace InMemoryCURD
{
    public class Program
    {
        static void Main(string[] args)
        {
            Services ser = new Services();
            var list=ser.GetAllEmployee();
            foreach (var item in list) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");
            ser.Delete(2);
            list = ser.GetAllEmployee();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");
            ser.Update(new Employee() { Id = 3, Addresss = "Sambhajinagar",Name="Ajinkya",Salary=45214,Gender='M' });
            list = ser.GetAllEmployee();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");
            ser.Add(new Employee() { Name = "Sushil", Id = 2, Salary = 87451, Gender = 'M', Addresss = "Kannad" });
            list = ser.GetAllEmployee();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");


        }
    }
}
