using System;
using System.Collections.Generic;
using System.Text;

namespace BankBalance
{
    class Checking : Account
    {
        private string AccountHolder { get; set; }
        protected override decimal StartBalance { set { base.StartBalance = value - 10; } }
        public Checking(string name, decimal balance)
        {
            AccountHolder = name;
            BankBalance = balance + StartBalance;
            Console.WriteLine($"Welcome {AccountHolder} to your Checking account");
            ShowStartBalance();
            ShowCurrentBalance();
            ShowClosingBalance();
        }

     
        public void DeductServiceCharge()
        {
            BankBalance -= 1.5m;
        }

        public override void ShowStartBalance()
        {
            base.ShowStartBalance(); //optional call to the base method
            Console.WriteLine($"Your account was Debited: {StartBalance.ToString("C")}");
        }

        protected override void ShowClosingBalance()
        {
            DeductServiceCharge();
            Console.WriteLine("Your Closing Balance is : " + BankBalance);
        }


    }
}
