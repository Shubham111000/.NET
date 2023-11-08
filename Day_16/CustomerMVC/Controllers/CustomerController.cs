using CustomerMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerMVC.Controllers
{
    public class CustomerController : Controller
    {
        ICustomer customer;
        public CustomerController(ICustomer customer) 
        {
            this.customer = customer;
        }
        public IActionResult Index()
        {
            return View(customer.GetAllCustomer());
        }
    }
}
