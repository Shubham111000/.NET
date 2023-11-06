using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_of_Baroda
{
    public class SavingAcccount : Account
    {
        public  const Double minbal = 1000;
        public SavingAcccount(String Name, Double Balance) : base(Name, Balance) { }
        

        public override void Withdraw(double Ammount)
        {
            if (Ammount > Balance)
                throw new InsufficientBalance("Balacne is not sufficient",Name);
            else if ((Balance - Ammount) < 1000)
                throw new InsufficientBalance("Ammount will be less than Minimum Balance", Name);
            else
            {
                Balance -= Ammount;
                onSomevent(this, Ammount, Balance);

            }    
        }
    }
}
