namespace Q1
{
    internal class Program
    {
        static  CustomerServices customerServices=new CustomerServices();
        static void Main(string[] args)
        {
            Display();
            Console.WriteLine("_______________");
            Add(new Customer() { Id = 5, Name = "sushil",BillAmt=5000,Location="Kannad",Mobile="9972014563"});
            Display();
            Console.WriteLine("_______________");
            SearchByBill(30000);
            Console.WriteLine("_______________");
            SearchByName('s');
            Console.WriteLine("_______________");
            SearchByLocation("Andheri");
            Console.WriteLine("_______________");
            Count();
            Console.WriteLine("_______________");
            Delete(5);
            Display();
            Console.WriteLine("_______________");
            update(new Customer() { Id = 1, Name = "sushil", BillAmt = 5000, Location = "Kannad", Mobile = "9972014563" });
            Display();
            Console.WriteLine("_______________");
            Display(2);

        }
        static void Display(int id) 
        {
            Console.WriteLine(customerServices.GetCustomer(id));
        }
        static void Display() 
        {
            var list=customerServices.GetAllCustomers();
            foreach (var customer in list) 
            {
                Console.WriteLine(customer);
            }
        }
        static void Add(Customer customer) 
        {
            customerServices.Add(customer);
        }
        static void update(Customer customer) 
        {
            customerServices.Update(customer);
        }
        static void Delete(int id) 
        {
            customerServices.Delete(id);
        }
        static void SearchByLocation(string location)
        {
           var list= customerServices.SearchByLocation(location);
            foreach (var customer in list)
            {
                Console.WriteLine(customer);
            }
        }
        static void SearchByName(char s)
        {
          var list=  customerServices.SearchByName(s);
            foreach (var customer in list)
            {
                Console.WriteLine(customer);
            }
        }
        static void SearchByBill(int Ammount) 
        {
            var list=customerServices.SearchByAmmount(Ammount);
            foreach (var customer in list)
            {
                Console.WriteLine(customer);
            }
        }
        static void Count() 
        {
            customerServices.Count();
        }
    }
}