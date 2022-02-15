//Author: Shadril Hassan Shifat [20-42451-1] 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Account
    {
        private string accName, acid;
        private int balance;

        public Account()
        {
            Console.WriteLine("Default constructor of Account class is called.");
        }
        public Account(string accName, string acid, int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }
        public string AccName
        {
            get 
            {
                return accName; 
            }
            set 
            { 
                accName = value; 
            }
        }
        public string Acid
        {
            get 
            { 
                return acid; 
            }
            set 
            { 
                acid = value; 
            }
        }
        public int Balance
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
        public void Deposit(int amount)
        {
            this.balance += amount;
            Console.WriteLine("Amount " + amount + " diposited successfully! Total balance : " + this.balance + " $");
        }
        public void Withdraw(int amount)
        {
            this.balance -= amount;
            Console.WriteLine("Amount " + amount + " withdrwan successfully! Total balance : " + this.balance + " $");
            
        }
        public void Transfer(int amount, Account receiver)
        {
            if(amount <= this.balance)
            {
                receiver.balance+=amount;
                this.balance -= amount;
                Console.WriteLine("Transfer $ "+amount+" successfully completed!");
                Console.WriteLine("Sender Balance : "+ this.balance+" $");
                Console.WriteLine("Receiver Balance : " + receiver.balance +" $");
            }
            else
            {
                Console.WriteLine("Insufficient Funds!");
            }
        }
    }
}
