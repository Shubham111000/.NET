namespace CustomerMVC.Models
{
    public class CustomerServices : ICustomer
    {
        static List<Customer> customerlist;

        public CustomerServices() 
        {
            customerlist=new List<Customer>() { new Customer() {Name="Shubham",Id=1,MobileNumber="7709796352",BillAmmout=7405.55f },
                                                new Customer(){Name="Akshay",Id=2,MobileNumber="981717845",BillAmmout=4785},
                                                new Customer(){Name="Sushil",Id=3,BillAmmout=4788.05f,MobileNumber="1467617167" }
                                              };
        }

        public List<Customer> GetAllCustomer()
        {
            return customerlist;
        }
    }
}
