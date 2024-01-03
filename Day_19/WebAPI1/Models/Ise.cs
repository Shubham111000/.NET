namespace WebAPI1.Models
{
    public interface IServices
    {
        public IEnumerable<Employee> GetEmployees();
        public Employee GetEmployee(int id);
        public Employee Add (Employee employee);
        public Employee Update (Employee employee,int id);
        public Employee Delete (int id);
        public IEnumerable<Employee> GetEmployeeByName(string name);
        public IEnumerable<Employee> GetEmployeeByAddress(string address);
    }
}
