using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_of_Baroda
{
    public class CurrentAccount:Account
    {
        public CurrentAccount(String Name, Double Balance) : base(Name, Balance) { }

        public override void Withdraw(double Ammount)
        {
            Balance -= Ammount;
            onSomevent(this, Ammount, Balance);
        }
    }
}
