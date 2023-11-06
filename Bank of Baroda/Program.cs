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
            List<Account> list = new List<Account>();

            try
            {

                list.Add(new SavingAcccount("Shubham Gaikwad", 450000));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                list.Add(new CurrentAccount("Akshay Shinde", 550000));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                list.Add( new CurrentAccount("Ajinkya Anawade", 5000000));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                list.Add(new CurrentAccount("Sushil", 550000));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                list.Add(new SavingAcccount("Akshay ", 550000));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                list.Add( new CurrentAccount("Akshay Shinde                ", 550000));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("--------------------------------------------");
            foreach (Account account in list) 
            {
                Console.WriteLine($"Id= {account.ID} name ={account.Name}  Balance = {account.ShowBalnce()}");
            }
            Console.WriteLine("--------------------------------------------");
            list[0].Deposit(145000);
            try 
            { 
                list[1].Withdraw(100000); 
            } 
            catch (Exception e) 
            { 
                Console.WriteLine(e); 
            }
            Console.WriteLine(list[4].ID+" "+ list[4].Name + " After deposting intrest your updated Balance is " + SavingAcccount.Payintrest((SavingAcccount)list[4])+" balance is "+ list[4].ShowBalnce()); 


    

            
        }
            
    }

}

