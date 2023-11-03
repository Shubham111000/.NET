/*
1) Write a method which will return sum of digit and using out variable let it send count of digit also.
   i/p input 123 return 6 in out  varible (3) 
*/

namespace Task_1
{
    internal class Program
    {
        public static void Addition(int x) 
        {
            int c = 0;
            int sum = 0;
            while (x != 0)
            {
                int r = x % 10;
                sum += r;
                x /= 10;
                c++;
            }
            Console.WriteLine($"Count of numbers are {c} and addition of numbers are {sum} ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            Addition(int.Parse(Console.ReadLine()));
        }
    }
}