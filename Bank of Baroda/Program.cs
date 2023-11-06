using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bank_of_Baroda
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                SavingAcccount customer1 = new SavingAcccount("Shubham Gaikwad", 450000);
                customer1.Withdraw(4500);
                customer1.Deposit(450000);
                SavingAcccount cust2=new SavingAcccount("Shu",45000);
                cust2.Withdraw(4500);



            }
            catch (Exception e) 
            {
                Console.WriteLine(e);
            }
        }

    }

}
