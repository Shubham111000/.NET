/*
 1) Create 2 string variable and accept data from user. Using equals and == check data entered by user
    is same or not.print gethashcode for both string varible. Also use referenceEquals and observe output.
 */


namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string 1");
            string str1=Console.ReadLine();
            Console.WriteLine("Enter a string 2");
            String str2=Console.ReadLine();
            Console.WriteLine(str1.Equals(str2));
            Console.WriteLine(str1.GetHashCode());
            Console.WriteLine(str2.GetHashCode());
            Console.WriteLine(ReferenceEquals(str1, str2));
        }
    }
}