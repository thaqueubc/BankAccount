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
            : base($"{accountHolderA} and {accountHolderB}" , balance)
        {
            ShowAccountHolderName();
            AccountHolderA = accountHolderA;
            AccountHolderB = accountHolderB;
           
        }

        public void ShowAccountHolderName()
        {
            //Console.WriteLine("Acoount Holder A : " + AccountHolderA);
            //Console.WriteLine("Acoount Holder B : " + AccountHolderB);
            Console.WriteLine($"Welcome {AccountHolderA} and {AccountHolderB} to your Joint Account");
        }


    }
}
