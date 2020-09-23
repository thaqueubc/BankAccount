using System;
using System.Collections.Generic;
using System.Text;

namespace BankBalance
{
    abstract class Account
    {
        protected decimal BankBalance { get; set; }

        protected virtual decimal StartBalance { get; set; }

        protected Account()
        {
            //Console.WriteLine("Inside the Account base class constructor");
            StartBalance = 0;
        }

        public virtual void ShowStartBalance()
        {
            Console.WriteLine("Thank you for opening your account.");
        }

        public void ShowCurrentBalance()
        {
            Console.WriteLine($"The Current balance is: {BankBalance.ToString("C")}");
        }

        protected abstract void ShowClosingBalance();

    }
}
