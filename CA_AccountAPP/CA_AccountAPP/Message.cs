using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_AccountAPP
{
    class Message
    {
        public void email(double a, double Balance, string name)
        {
            Console.WriteLine("E-mail : Amount withdrawn : {0} new bal={1} name={2}", a, Balance, name);
        }

        public void mobile(double a, double Balance, string name)
        {
            Console.WriteLine("Mobile : Amount withdrawn : {0}new bal={1} name={2}", a, Balance, name);
        }
    }

}
