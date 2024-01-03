using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class Customer
    {
        public int Id {  get; set; }
        public string Name {  get; set; }
        public String Location { get; set; }
        public String Mobile {  get; set; }
        public int BillAmt {  get; set; }
        public override string ToString()
        {
            return $"Id={Id} Name={Name} Location={Location}  Mobile={Mobile} BillAmmt={BillAmt}";
        }

    }
}
