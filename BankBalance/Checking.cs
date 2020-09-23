using System;
using System.Collections.Generic;
using System.Text;

namespace BankBalance
{
    class Checking : Account
    {
        protected override decimal StartBalance { set { base.StartBalance = value - 10; } }
        public Checking(decimal balance)
        {
            //Console.WriteLine("Inside the Checking child class constructor");
            BankBalance = balance + StartBalance;
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
            Console.WriteLine($"Your account was Debited: {StartBalance.ToString("C")}");
            base.ShowStartBalance(); //optional call to the base method
        }

        protected override void ShowClosingBalance()
        {
            DeductServiceCharge();
            Console.WriteLine("Your Closing Balance is : " + BankBalance);
        }


    }
}
