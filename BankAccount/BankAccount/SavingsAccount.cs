using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class SavingsAccount : BankAccount
    {
        private double interestRate;

        public SavingsAccount(string accNumber, string accHolder, double balance, double interestRate) : base(accNumber,accHolder, balance)
        {
            this.interestRate = interestRate;
        }

        public void ApplyInterest(double interestRate)
        {
            double interest = Balance() * interestRate / 100;
            Deposit(interest);
            Console.WriteLine("Interest rate of " + interestRate + " is applied. " + "Balance is : " + Balance());
        }


    }
}
