using System;
using System.Collections.Generic;
using System.Text;

namespace BankBalance
{
    class Savings : Account
    {
        private string AccountHolder { get; set; }
        protected decimal balance { get; set; }

        protected override decimal StartBalance { set { base.StartBalance = value + 50; } }
        
        public Savings() { }
        public Savings( string name , decimal balance)
        {
            AccountHolder = name;
            BankBalance = balance + StartBalance ;
            Console.WriteLine($"Welcome {AccountHolder} to your account");
            ShowStartBalance();
            ShowCurrentBalance();
            ShowClosingBalance();
           
        }

        private void WelcomeMessage()
        {
           
        }

        public void AddMonthlyInterest(decimal interest)
        {
            BankBalance *= (1.0m + interest);
        }

        public override void ShowStartBalance()
        {
            
            base.ShowStartBalance(); //optional call to the base method
            Console.WriteLine($"Your account was credited: {StartBalance.ToString("C")}");
          
        }

        protected override void ShowClosingBalance()
        {
            AddMonthlyInterest(0.0045m);
            Console.WriteLine("Your Closing Balance is : " + BankBalance);
        }
    }
}
