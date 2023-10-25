
using Task;

internal class Program
{
    private static void Main(string[] args)
    {
        Student s1 = new Student("akshay", 39, 69, 50);
        s1.disp();
        Student s2 = new Student("ajinkya", 70, 58, 65);
        s2.disp();
    }
}