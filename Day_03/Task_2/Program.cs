using Task_2;

internal class Program
{
    private static void Main(string[] args)
    {
        Account p1 = new Account("yash",25000);
        Account p2 = new Account("Shubham", 300000);
        p1.withdraw(10000);
        p2.deposit(50000);
        p1.Disp();
        p2.Disp();


    }
}