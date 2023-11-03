using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_AccountAPP
{
    class Saving : Account
    {
        public Saving(String name, Double bal)
            : base(name, bal)
        {
        }

        public override void withdraw(double a)
        {
            Balance = Balance - a;
            OnWithdraw(a, Balance, Name);

        }
    }

}
