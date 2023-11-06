using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_of_Baroda
{
    public class SavingAcccount : Account
    {
        static double RateOfIntrest = 0.34;
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
        public static Double  Payintrest(SavingAcccount ref1) 
        {
            Double Intrest = ref1.Balance * RateOfIntrest;
            ref1.Balance+=Intrest;
            return Intrest;
        } 
        
    }
}
