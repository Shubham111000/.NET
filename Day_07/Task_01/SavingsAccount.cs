using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_01;

namespace Task_3
{
    internal class SavingsAccount :Account
    {
        public override string ToString()
        {
            return ($"Account ID is {ID} Account Name is {Name} Accounts balance is {Balance} Account Type is SaVings Account");
        }
        public override void Withdraw(Double Ammount)
        {
            if (Ammount >= Balance || (Balance - Ammount) <= 2500)
            {
                Console.WriteLine("Sorry For the Inconvienece you can't Withdraw Ammount");
            }
            else
            {
                Balance -= Ammount;
                Console.WriteLine($"Ammount of {Ammount} Is Withdrawn");
            }
        }
    }
}