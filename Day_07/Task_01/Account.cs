using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public class Account
    {
        int id;
        static int getid = 0;
        public Account() 
        {
            id = ++getid;
        }
        static Account()
        {
            Console.WriteLine("Welcome TO State Bank Of India");
        }
        public string Name { get; set; }
        public int ID { get { return id; } }
        public Double Balance { get; set; }

        public void Deposit(Double Balance)
        {
            this.Balance += Balance;
            Console.WriteLine($"Ammoiunt of {Balance} is Deposited");
        }
        public virtual void Withdraw(Double Ammount) 
        {
            Balance -= Ammount;
        }

    }
}