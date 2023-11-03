using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*

Create Array Of Objects Of Account and Disply name and balance.

*/






namespace Array_TasK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account.Id = 0;
            Account[] array=new Account[3];
            for (int i = 0; i < array.Length; i++) 
            {
                
                Console.WriteLine("Enter The Name");
                string name=Console.ReadLine();
                Console.WriteLine("Enter The Balance");
                int a=int.Parse(Console.ReadLine());
                array[i] = new Account(name, a);
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Disp();
            }
        }
    }
}
