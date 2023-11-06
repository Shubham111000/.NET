using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bank_of_Baroda
{
    public  delegate void Withdrawn(Account @ref, Double Ammount, Double Balance);
    public abstract class Account
    {
        public  static event Withdrawn somevent;
        static int getid = 0;
        int Id;
        string name;
        Double balance;
        protected void onSomevent(Account @ref, Double Ammount, Double Balance) 
        {
            //somevent += EventSubscriber.Email;
            //somevent += EventSubscriber.Message;
            if (somevent != null)
                somevent(@ref, Ammount, Balance);
        }
        static Account() 
        {
            //Agent.AgentS();
            Console.WriteLine("Welcome To Bank of Baroda");
        }
        public Account(string name,Double balance)
        {
            if (getid > 5)
                throw new Exception("Caapacity Full");
            else
            Name= name;
            Balance = balance;
            Id= ++getid;
        }
        public int ID { get { return Id; } }

        
        public string Name 
        {
            set
            {
                if (value.Length > 2)
                    name = value;
                else
                    throw new Exception();
            }
            get 
            {
                return name;
            }
        }
        protected  Double  Balance 
        {
            get 
            {
                return balance;
            }
            set 
            {
                balance = value;
            }    
        }
        public void Deposit(double Ammount) 
        {

            Balance += Ammount;
            Console.WriteLine("Account Id =" + Id + " " + Ammount + "$" + "  Deposited and updated Balance is " + Balance + "$");

        }
        public abstract void Withdraw(Double Ammount);








    }
}
