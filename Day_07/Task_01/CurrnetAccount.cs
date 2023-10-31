using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class CurrentAccount : Account
    {
        public override void Withdraw(Double Ammount)
        {
            Balance -= Ammount;
            Console.WriteLine($"Ammount of {Ammount} Is WIthdrwan");
        }
        public override string ToString()
        {
            return ($"Account ID is ={ID} Account Name is {Name} Accounts balance is {Balance} Account Type is Current Account");
        }
    }
}