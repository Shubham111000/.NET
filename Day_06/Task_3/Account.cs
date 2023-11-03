using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Account
    {
        static Account() 
        {
            Console.WriteLine("Welcome TO State Bank Of India");
        }
        public string Name { get; set; }
        public int ID { get; set; }
        public Double Balance { get; set; }

        public void Deposit (Double Balance) 
        {
            this.Balance += Balance;
            Console.WriteLine($"Ammoiunt of {Balance} is Deposited");
        }
    }
}
