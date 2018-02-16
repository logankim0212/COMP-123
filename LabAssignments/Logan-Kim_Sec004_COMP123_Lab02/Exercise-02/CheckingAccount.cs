using System;
/* Create a CheckingAccount class (CheckingAccount.cs) that has the following
 * instance variables:
 *      -   Account number, customer name, account balance
 *      -   Define only property getter for account number and customer name
 *      -   Define property getter and setter for account balance. Balance
 *          should be positive and minimum 50.00 dollars all the time. 
 *      -   Class should have defined a constructor:
 *              o For initializing all the instance data members
 *      -   Define one public method - double withdraw(double amount) which is
 *          used for taking out money.With every withdrawal, there is 
 *          transaction fee of 3.00 dollars.
 *      -   Define a public method - String toString() which is used to display
 *          the object's data
 */
namespace Exercise02
{
    public class CheckingAccount
    {
        // Constant variable for transaction fee
        private const double transactionFee = 3;

        // Instant data
        private double accountBalance;

        // Auto-implemented read-only property
        public int AccountNumber { get; }
        public string CustomerName { get; }

        // Property
        public double AccountBalance
        {
            get
            {
                return accountBalance;
            } // end get
            set
            {
                if (value >= 50)
                {
                    accountBalance = value;
                } // end if
            } // end set
        } // end property

        // constructor
        public CheckingAccount(int accountNumber, string customerName,
                               double accountBalance)
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
            AccountBalance = accountBalance;
        } // end constructor

        // Method for withdraw
        public double withdraw(double amount)
        {
            AccountBalance -= amount + transactionFee;
            return accountBalance;
        } // end method

        // Method for displaying datas
        public override string ToString()
        {
            // Condition
            if (accountBalance < 50)
            {
                return string.Format("Account Balance cannot be less than $50.");
            } // end if
            return string.Format("Account Number: {0} \nCustomer Name: {1}" +
                                 " \nAccount Balance: {2:C}", AccountNumber,
                                 CustomerName, AccountBalance);
        } // end method
    } // end class
} // end namespace
