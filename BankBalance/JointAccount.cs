using System;
using System.Collections.Generic;
using System.Text;

namespace BankBalance
{
    class JointAccount : Savings
    {
        private string AccountHolderA { get; set; }

        private string AccountHolderB { get; set; }

        public JointAccount(string accountHolderA, string accountHolderB, decimal balance)
            : base(balance)
        {
            AccountHolderA = accountHolderA;
            AccountHolderB = accountHolderB;
           
        }

        public void showAccountHolderName()
        {
            Console.WriteLine("Acoount Holder A : " + AccountHolderA);
            Console.WriteLine("Acoount Holder B : " + AccountHolderB);

        }


    }
}
