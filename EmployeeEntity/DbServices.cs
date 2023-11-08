using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeEntity.Models;

namespace EmployeeEntity
{
    public class DbServices
    {
        private static readonly DepartmentEmployee DEmployee=new DepartmentEmployee();
        public void DisplayAll() 
        {
            foreach(var i in DEmployee.EmployeeSet) 
            {
                Console.WriteLine(i);
            }
        }
        public void addData(Employee e) 
        {
            DEmployee.Add<Employee>(e);
            DEmployee.SaveChanges();
        }
        public void deleteData(int id) 
        {
            Employee s= DEmployee.EmployeeSet.FirstOrDefault(e=>e.Id==id);
        }

    }
}
