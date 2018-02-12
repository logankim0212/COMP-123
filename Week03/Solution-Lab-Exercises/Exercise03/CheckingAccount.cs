using System;
/*
 * Create a CheckingAccount class (CheckingAccount.cs) that has the following
 * instance variables:
 *      - Account number , customer name, account balance
 *      - Define properties with validations for all the above.
 *      - Account number should only have getter method.
 *      - Account balance cannot be negative
 *      - Class should have defined two overloaded constructors:
 *              o One for initializing all the instance data members
 *              o Second for initializing only Account number, customer name
 *      - Define one public method - double withdraw (double amount) which is
 *        used for taking out money
 *      - Define a public method – String toString() which is used to display
 *        the object’s data
 */
namespace Exercise03
{
    public class CheckingAccount
    {
        private double accountBalance;

        public int AccountNumber { get; }
        public string CustomerName { get; set; }
        public double AccountBalance
        {
            get
            {
                return accountBalance;
            }
            set
            {
                if (value > 0)
                {
                    accountBalance = value;
                }
            }
        }

        public CheckingAccount(int accountNumber, string customerName,
                               double accountBalance)
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
            AccountBalance = accountBalance;
        } // end constructor

        public CheckingAccount(int accountNumber, string customerName)
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
        } // end constructor
        public double withdraw(double amount)
        {
            return AccountBalance - amount;
        }
        public override string ToString()
        {
            return string.Format("Account Number: {0} \nCustomer Name: {1} \nAccount Balance: {2:C}"
                                 , AccountNumber, CustomerName, AccountBalance);
        }
    }
}
