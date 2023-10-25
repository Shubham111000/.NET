using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Account
    {
        static Account() 
        {
            Console.WriteLine("Welcome to Bank of Baroda");
        }
        static int Id;
        string name;int id, balance;
        public Account(string name,int balance) 
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
            Console.WriteLine($"name = {name} balance = {balance}");
        }
    }
}
