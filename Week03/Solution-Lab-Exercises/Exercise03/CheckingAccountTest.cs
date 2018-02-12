using System;
/*
 * Create a driver class – CheckingAccountTest (CheckingAccountTest.cs) which
 * tests above class by at least creating two objects of the CheckingAccount
 * class.
 */
namespace Exercise03
{
    class CheckingAccountTest
    {
        public static void Main(string[] args)
        {
            CheckingAccount customer1 = new CheckingAccount(123456789, "Logan Kim",
                                                 80000);
            Console.WriteLine(customer1);
            Console.WriteLine("Account Balance after Withdraw: {0:C}", customer1.withdraw(1000));
        }
    }
}
