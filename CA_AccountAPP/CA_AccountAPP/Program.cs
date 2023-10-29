using CA_AccountAPP;

delegate void wd(double x, double bal, string nm);
abstract class Account
{
    public event wd wdevent;
    static int id;
    int Accid;
    string name;
    double balance;
    protected const double minbal = 1000;

    public Account(String name, double balance)
    {
        Accid = ++id;
        Name = name;
        Balance = balance;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public void deposit(double a)
    {
        Balance = Balance + a;
    }

    public void OnWithdraw(double a, double Balance, string name)
    {
        if (wdevent != null)
            wdevent(a, Balance, name);
    }
    public abstract void withdraw(double e);

}
class Program
{
    static void Main(string[] args)
    {
        Message m = new Message();

        Account[] a = new Account[3];

        a[0] = new Saving("A", 35000);
        a[1] = new Saving("B", 18000);
        a[2] = new Current("C", 40000);

        for (int i = 0; i < a.Length; i++)
        {
            a[i].wdevent += m.email;
            a[i].wdevent += m.mobile;
        }

        a[0].deposit(10000);
        a[1].withdraw(1000);
        a[2].withdraw(12000);
    }
}

