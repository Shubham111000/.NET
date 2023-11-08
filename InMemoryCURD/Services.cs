using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryCURD
{
    public class Services:IEmployeeeRepository
    {
        private static List<Employee> employees;
        public Services() 
        {
            employees = new List<Employee>() 
            {
                new Employee(){Name="Shubham",Id=1,Salary=78451,Gender='M',Addresss="Solpur"},
                new Employee(){Name="Sushil",Id=2,Salary=87451,Gender='M',Addresss="Kannad"},
                new Employee(){Name="Ajinkya",Id=3,Salary=78000,Gender='M',Addresss="Kannad"},
            };   
        }

        public Employee Add(Employee e)
        {
            employees.Add(e);
            return e;
        }

        public Employee Delete(int Id)
        {
            Employee employee = employees.FirstOrDefault(e => e.Id == Id);
            if(employee != null) 
            {
                employees.Remove(employee);    
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return employees;
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = employees.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if(employee != null) 
            {
                employee.Name = employeeChanges.Name;
                employee.Salary = employeeChanges.Salary;
                employee.Gender = employeeChanges.Gender;
                employee.Addresss= employeeChanges.Addresss;
            }
            return employee;
        }
    }
}
