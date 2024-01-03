using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class CustomerServices:IcustomerRepository
    {
        private static List<Customer> list;
        public CustomerServices()
        {
            list = new List<Customer>()
            {new Customer(){Id=1,Name="Raj",Location="Andheri",Mobile="9769201089",BillAmt=25850},
             new Customer(){Id=2,Name="Geeta",Location="Andheri",Mobile="9999201089",BillAmt=3850},
             new Customer(){Id=3,Name="Rohan",Location="Juhu",Mobile="99201089",BillAmt=26750},
             new Customer(){Id=4,Name="kavita",Location="Juhu",Mobile="97699201089",BillAmt=20250}
            };
        }

        public Customer Add(Customer customer)
        {
            list.Add(customer);
            return customer;
        }

        public Customer Delete(int id)
        {
            Customer customer= list.FirstOrDefault(z=>z.Id==id);
            if (customer != null)
                list.Remove(customer);
            return customer;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return list;
        }

        public Customer GetCustomer(int id)
        {
            Customer customer = list.FirstOrDefault(z => z.Id == id);
            return customer;
        }

        public Customer Update(Customer customerchange)
        {
            Customer customer = list.FirstOrDefault(z => z.Id == customerchange.Id);
            if (customer != null)
            {
                customer.Name = customerchange.Name;
                customer.Location = customerchange.Location;
                customer.Mobile = customerchange.Mobile;
            }
            return customer;
        }
        public IEnumerable<Customer> SearchByLocation(string location) 
        {
            return list.FindAll(z=> z.Location==location);
        }
        public IEnumerable<Customer> SearchByName(Char c)
        {
            return list.FindAll(z => z.Name.StartsWith(c));
        }
        public IEnumerable<Customer> SearchByAmmount(int Ammount)
        {
            return list.FindAll(z => z.BillAmt>Ammount);
        }
        public void Count()
        {
            Console.WriteLine(list.Count());
        }

    }
}
