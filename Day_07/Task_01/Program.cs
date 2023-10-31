/*
//Create class Account having member id, name, balance.
//Id autoincrement write read only property
//Write getter setter for name and balance.
//Balance can be modified only by child class.
//This has virtual withdraw method which will 0.
//It has deposit method.
//Create two child class current and saving and override withdraw method. 
//Create reference of Account class and point to saving account
//and  current account. Using parent’s reference call withdraw method and deposit method.
//Use ToString method to display status of the object [id name balance]
*/

using Task_3;

namespace Task_01
{
    internal class Program
    {
        public static void WD(Account account) 
        {
            Console.WriteLine(account);
            Console.WriteLine("Enter The Ammount you want to Withdraw");
            account.Withdraw(int.Parse(Console.ReadLine()));
        }
        static void Main(string[] args)
        {
            Account account1 = new SavingsAccount() { Name = "Shubham", Balance = 45000 };
            Account account2 = new CurrentAccount() { Name = "Sushil",  Balance = 50000 };
            WD(account1);
            WD(account2);
            Console.WriteLine(account1);
            Console.WriteLine(account2);



        }
    }
}