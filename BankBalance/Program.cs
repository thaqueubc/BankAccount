using System;

namespace BankBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            Savings mySavingAccount = new Savings("Tasnuva Haque", 100);
            
            //mySavingAccount.ShowStartBalance();
            //mySavingAccount.AddMonthlyInterest(0.0045m);

            Console.WriteLine("\n");
            Checking myCheckingAccount = new Checking("Tasnuva Haque", 100);
            //myCheckingAccount.ShowStartBalance();
            //myCheckingAccount.DeductServiceCharge();
            Console.WriteLine("\n");

            JointAccount ourJointAccount = new JointAccount("Tasnuva Haque", "Nobinur Rahman", 150);
            //ourJointAccount.showAccountHolderName();
            //ourJointAccount.ShowStartBalance();
            //ourJointAccount.AddMonthlyInterest(0.0049m);

        }
    }
}
