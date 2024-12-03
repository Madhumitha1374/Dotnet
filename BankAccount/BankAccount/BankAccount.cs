using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class BankAccount
    {
        private String accNumber;
        private String accHolderName;
        private double balance;

        public BankAccount(string accNumber, string accHolderName, double balance)
        {
            this.accNumber = accNumber;
            this.accHolderName = accHolderName;
            this.balance = balance;
        }

        public void Deposit(double amount)
        {
            if(amount > 0)
            {
                this.balance += amount;
                Console.WriteLine("Amount deposited. Balance is : " + this.balance);
            }
            else
            {
                Console.WriteLine("Amount must be positive");
            }
        }
        public void WithDraw(double amount)
        {
            if(this.balance > 0 && amount <= balance && amount > 0)
            {
                this.balance -= amount;
                Console.WriteLine("Withdrawl of " + amount + " is successful. Balance is : " + this.balance);
            }
            else
            {
                Console.WriteLine("Withdrawl has been failed. Check you Balance");
            }
        }
        public double Balance()
        {
            return this.balance;
            Console.WriteLine("Balance is : " + this.balance);
        }

        public void getAccountNumber()
        {
            Console.WriteLine("Account number is : " + this.accNumber);
        }

        public void getAccHolderName()
        {
            Console.WriteLine("Account Holdername is : " + this.accHolderName);
        }
    }
}
