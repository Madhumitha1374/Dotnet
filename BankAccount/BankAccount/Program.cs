using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("1234567834", "Madhumitha", 100);
            account1.Deposit(1000);
            account1.WithDraw(200);
            double bal = account1.Balance();
            account1.getAccHolderName();

            SavingsAccount sa = new SavingsAccount("453453423432", "Madhavi", 10000, 100);
            sa.ApplyInterest(100);
            sa.Balance();


        }
    }
}
