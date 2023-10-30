/*
2) Write a method which will accept two number and return all even number between it as array and 
   also give count in out variable.
   int count;
   int[] result = Dojob(5,30);
*/

namespace Task_2
{
    internal class Program
    {
        public static int[] Dojob(int x, int y)
        {
            int[] r = new int[((y - x) / 2) + 1];
            if (x % 2 == 0)
            {
                for (int i = 0; i < r.Length; i++)
                {
                    r[i] = x;
                    x += 2;
                }
            }
            else
            {
                x = x + 1;
                for (int i = 0; i < r.Length; i++)
                {
                    r[i] = x;
                    x += 2;
                }

            }
            return r;
        }


        static void Main(string[] args)
        {
            int[] r = Dojob(4, 31);
            foreach (int i in r)
            {
                Console.WriteLine(i);
            }
        }
    }
}

