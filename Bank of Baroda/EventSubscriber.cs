using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_of_Baroda
{
    public class EventSubscriber
    {
        public static void Email(Account @ref, Double Ammount,Double Balance)
        {
            Console.WriteLine("Email Sent");
            Console.WriteLine("Account Id =" + @ref.ID + " " + Ammount + "$" + " wihtdrawn and Updated Balance is " + Balance + "$");
        }
        public static void Message(Account @ref, Double Ammount, Double Balance)
        {
            Console.WriteLine("Message Sent");
            Console.WriteLine("Account Id =" + @ref.ID + " " + Ammount + "$" + " wihtdrawn and Updated Balance is " + Balance + "$");

        }
        
    }
}
