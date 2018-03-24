using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02
{
    abstract class BankAccount
    {
        private int accountNumber;
        private string customerName;
        private string address;
        private double accountBalance = 100.00;
        private double rate = 1.2;

       public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                value = accountNumber;
            }
        }


        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                value = customerName;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                value = address;
            }
        }
        public double AccountBalance
        {
            get
            {
                return accountNumber;
            }
            set
            {
                if (value > 0.0)
                {
                    value = accountNumber;
                }
            }
        }
        public double Rate
        {
            get
            {
                return rate;
            }
            set
            {
                if (value > 0.0)
                {
                    value = rate;
                }
            }
        }

        public BankAccount(int accountNumber,string customerName,string address, double accountBalance, double rate)
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
            Address = address;
            AccountBalance = accountBalance;
            Rate = rate;
        }
        public override string ToString()
        {
            return string.Format("AccountNumber: {0} /nCustomerName: {1} /nAddress: {2} /nAccountBalance: {3} /nRate: {4}",AccountNumber,CustomerName,Address,AccountBalance,Rate);
        }
        public abstract double CalculateInterest();
    }                            
}                                
                                  