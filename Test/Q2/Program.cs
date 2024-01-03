using System.Dynamic;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number OF lines");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                for (int s = n; s > i; s--)
                     Console.Write(" ");
                for (int j = 0; j <i ; j++)
                    Console.Write("*");
                for(int q=0;q< (i-1);q++)
                    Console.Write("*");    
                Console.WriteLine();
            }
        }
    }
}