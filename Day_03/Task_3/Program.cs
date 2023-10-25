using System.Linq.Expressions;
using Task_3;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee e1 = new Employee("Akshay",24500);
        Employee e2 = new Employee("Shubham",55600);
        e1.disp();
        e2.disp();

    }
}