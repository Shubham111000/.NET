using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_of_Baroda
{
    public class InsufficientBalance:ApplicationException
    {
        string message;
        string Name;
        public InsufficientBalance(String message,string Name) 
        {
            this.message = message;
            this.Name = Name;
        }
        public override string ToString() 
        {
            return ($"message: {message} Name: {Name}");
        }
    }
}
