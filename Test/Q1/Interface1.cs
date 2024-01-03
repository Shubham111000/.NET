using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public interface IcustomerRepository
    {
        Customer GetCustomer(int id);
        IEnumerable<Customer> GetAllCustomers();
        Customer Add(Customer customer);
        Customer Update(Customer customerchange);
        Customer Delete(int id);

    }
}
