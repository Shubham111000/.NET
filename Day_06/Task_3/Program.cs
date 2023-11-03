/*
3)Create class Account having member variable id,name, balance.
Write getter/setter for id, name and balance
create method deposit which will increase balance
Create two child class currentaccount and saving account
It has member type,
In both the class create withdraw method who’ s job is to reduce balance.
In currentaccount negative balance allowed
In savingaccount –ve balance not allowed.
When you load application it should print name of bank.
New Savingaccount(1,”Raj”,50000,” “saving”)

*/
namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount account = new SavingsAccount() { Name = "Raj", ID = 16617, Balance=50000.0 };
            Console.WriteLine(account);
            account.Withdraw(50000);
            Console.WriteLine(account);
            CurrentAccount currentAccount = new CurrentAccount() { Name = "Jay", ID = 14617, Balance=450000 };
            Console.WriteLine(currentAccount);
            currentAccount.Withdraw(500000);
            Console.WriteLine(currentAccount);
            currentAccount.Deposit(50000);
            Console.WriteLine(currentAccount);
        }
    }
}