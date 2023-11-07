using ConsoleEntityApp.Models;

namespace ConsoleEntityApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            DbServices services = new DbServices();
            services.Display();
            Console.WriteLine("_______________________________");
            //services.Adddata(new Student { FirstName="Ajinkya",LastName="anawade"});
            //services.Display();
            //Console.WriteLine("_______________________________");
            services.Delete(17);
            services.Display();
            Console.WriteLine("_______________________________");
            var list=services.Customquery("Shubham");
            foreach (var item in list) 
            {
                Console.WriteLine(item.ToString());
            }
            //services.Display();
            Console.WriteLine("_______________________________");
            services.Liqdemo();

        }
    }
}