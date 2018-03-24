using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02
{
    class CheckingAccount:BankAccount
    {
        private double transactionFee = 1.5;

        public double Fee
        {
            get
            {
                return transactionFee;
            }
            set
            {
                value = transactionFee = 1.5;
            }
        }
        public CheckingAccount(double transactionFee, int accountNumber, string customerName, string address, double accountBalance, double rate):base(accountNumber, customerName, address, accountBalance, rate)
        {
            transactionFee = Fee;
        }

        public override string ToString()
        {
            return string.Format("{0}",base.ToString());
        }
        public double Debit(double amount)
        {
            int cont = 0;
            if (cont < 2)
            {
                return AccountBalance - amount;
            }
            else
            {
                return AccountBalance - (amount + 0.5);
            }
            
        }
        public override double CalculateInterest()
        {
            return Rate * AccountBalance;
        }
    }
}
