using System.Xml.Linq;

namespace WebAPI1.Models
{
    public class EmployeeServices : IServices
    {
        static List<Employee> employlist;
        public EmployeeServices() 
        {
            employlist = new List<Employee>()
            {
                new Employee() {FirstName="shubham",Id=1,LastName="Gaiwkad",Address="Solapur"},
                new Employee() {FirstName="Yash",Id=2,LastName="Hajare",Address="Nagapur"},
                new Employee() {FirstName="Ajinkya",Id=3,LastName="Anawade",Address="kannad"}
            };
            
        }

        public Employee Add(Employee employee)
        {
            employee.Id=employlist.Max(x => x.Id)+1;
            employlist.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = employlist.FirstOrDefault(a=>a.Id==id);
            if (employee != null)
                employlist.Remove(employee);
            return employee;
        }

        public Employee GetEmployee(int id)
        {
            Employee employee = employlist.FirstOrDefault(a => a.Id == id);
            return employee;
        }

        public IEnumerable<Employee> GetEmployeeByAddress(string address)
        {
            return employlist.FindAll(a => a.Address == address);
        }

        public IEnumerable<Employee> GetEmployeeByName(string name)
        {
            return employlist.FindAll(a=>a.FirstName==name);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return employlist;
        }

        public Employee Update(Employee employee1, int id)
        {
            Employee employee = employlist.FirstOrDefault(a => a.Id == id);
            if (employee != null) 
            {
                employee.FirstName=employee1.FirstName;
                employee.LastName= employee1.LastName;
                employee.Address=employee1.Address; 
            }
            return employee;
        }
    }
}
