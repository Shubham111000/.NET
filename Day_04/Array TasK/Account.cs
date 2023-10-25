using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_TasK
{
    public class Account
    {
        static Account()
        {
            Console.WriteLine("Welcome to Bank of Baroda");
        }
        public static int Id;
        string name; int id, balance;
        public Account(string name, int balance)
        {
            this.id = ++Id;
            this.name = name;
            this.balance = balance;
        }
        public void deposit(int amt)
        {
            balance += amt;

        }
        public void withdraw(int amt)
        {
            if (amt <= balance)
                balance -= amt;
            else
                Console.WriteLine("insufficient Balance");
        }
        public void Disp()
        {
            Console.WriteLine($" Id = {id} name = {name} balance = {balance}");
        }
    }
}
