using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_of_Baroda
{
    class Agent
    {
        public static void AgentS() 
        {
            Account.somevent += EventSubscriber.Email;
            Account.somevent += EventSubscriber.Message;
        }
    }
}
