using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI1.Models;

namespace WebAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IServices services;
            public EmployeeController(IServices services)
            {
                this.services = services;
            }
        [HttpGet]
        public IEnumerable<Employee> GetEmployees() 
        {
            return services.GetEmployees();
        }
        [HttpGet("{id:int}")]
        public Employee GetEmployee(int id) 
        {
            return services.GetEmployee(id);
        }
        [HttpGet("{FirstName}")]
        public IEnumerable<Employee> GetEmployeesByName(String FirstName)
        {
            return services.GetEmployeeByName(FirstName);
        }
        [HttpGet("Address/{Address}")]
        public IEnumerable<Employee> GetEmployeesByAddress(String Address)
        {
            return services.GetEmployeeByAddress(Address);
        }
        [HttpPut]
        public Employee PutEmployee(Employee employee,int id) 
        {
           return services.Update(employee, id);
        }
        [HttpPost]
        public Employee POStEmployee(Employee employee)
        {
            return services.Add(employee);
        }
        [HttpDelete]
        public Employee Delete(int id) 
        {
           return  services.Delete(id);
        }
    }
}

