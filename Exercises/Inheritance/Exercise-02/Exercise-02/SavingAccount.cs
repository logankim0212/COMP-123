using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02
{
    class SavingAccount:BankAccount
    {
        public SavingAccount(int accountNumber, string customerName, string address, double accountBalance, double rate):base(accountNumber,customerName, address, accountBalance,rate)
        {

        }

        public override double CalculateInterest()
        {
            return Rate * AccountBalance;
        }

        public override string ToString()
        {
            return string.Format("{0}", base.ToString());
        }

        public double Credit(double amount)
        {
            double newBalance=(AccountBalance + amount);
            return newBalance;
        }
    }
}
