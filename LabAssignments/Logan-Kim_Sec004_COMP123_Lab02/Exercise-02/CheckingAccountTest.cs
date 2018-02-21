using System;
/*
 * Create a test class - CheckingAccountTest (CheckingAccountTest.cs) which 
 * tests above class by at least creating two objects of the CheckingAccount
 * class with different set of data values.
 */
namespace Exercise02
{
    class CheckingAccountTest
    {
        public static void Main(string[] args)
        {
            // call class CheckingAccount with an information of customer1
            CheckingAccount customer1 = new CheckingAccount(123456789,
                                                            "Logan Kim",
                                                            1000);

            // print customer1 via the class CheckingAccount
            Console.WriteLine(customer1);

            // print customer1's account balance after withdraw from the class CheckingAccount
            Console.WriteLine("Account Balance After Withdraw (Commission fee" +
                              " of $3): {0:C}", customer1.withdraw(50));

            // call class CheckingAccount with an information of customer2
            CheckingAccount customer2 = new CheckingAccount(987654321,
                                                            "Kim Logan",
                                                            2000);

            // print customer2 via the class CheckingAccount
            Console.WriteLine(customer2);

            // print customer2's account balance after withdraw from the class CheckingAccount
            Console.WriteLine("Account Balance After Withdraw (Commission fee" +
                              " of $3): {0:C}", customer2.withdraw(100));
        } // end main
    } // end class
} // end namespace