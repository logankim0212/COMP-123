using System;

// Logan Kim: 300973239

namespace LoganKim_Exercise01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ShowMenu();
        } // end main

        // Method for Displaying Menu
        static void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("======== Logan’s Mortgage Systems ========");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|         1. House Mortgage              |");
            Console.WriteLine("|         2. Business Mortgage           |");
            Console.WriteLine("|         0. End program                 |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("==========================================");
            Console.Write("        Enter the number of your choice -> ");
        } // end method

        // Method for Showing Menu
        static void ShowMenu()
        {
            string number;
            do
            {
                // Display Menu
                DisplayMenu();
                number = Console.ReadLine();

                //Menu Choice
                switch (number)
                {
                    case "1":
                        // prompt user mortgage mumber
                        Console.Write("Enter the mortgage number: ");
                        int mortgageNumber1 = Convert.ToInt32(Console.ReadLine());

                        // prompt user customer name
                        Console.Write("Enter the customer name: ");
                        string customerName1 = Console.ReadLine();

                        // prompt user mortgage amount
                        Console.Write("Enter the mortgage amount: ");
                        double mortgageAmount1 = Convert.ToDouble(Console.ReadLine());

                        // prompt user yearly interest rate
                        Console.Write("Enter the yearly interest rate: ");
                        double yearlyInterestRate1 = Convert.ToDouble(Console.ReadLine());

                        // prompt user customer address
                        Console.Write("Enter the customer address: ");
                        string customerAddress1 = Console.ReadLine();

                        // prompt user property tax
                        Console.Write("Enter the property tax: ");
                        double propertyTax1 = Convert.ToDouble(Console.ReadLine());

                        // prompt user infrastructure tax

                        Console.WriteLine();

                        // call class HouseMortgage
                        HouseMortgage customer1 = new HouseMortgage
                            (mortgageNumber1, customerName1, mortgageAmount1,
                             yearlyInterestRate1, customerAddress1, propertyTax1);

                        // print customer1 via the class HouseMortgage
                        Console.WriteLine(customer1);

                        // print CalculateMonthlyMortgageInstallment from the class HouseMortgage
                        Console.WriteLine("Monthly mortgage installment: {0:C}",
                                          customer1.CalculateMonthlyMortgageInstallment());
                        break;
                    case "2":
                        // prompt user mortgage mumber
                        Console.Write("Enter the mortgage number: ");
                        int mortgageNumber2 = Convert.ToInt32(Console.ReadLine());

                        // prompt user customer name
                        Console.Write("Enter the customer name: ");
                        string customerName2 = Console.ReadLine();

                        // prompt user mortgage amount
                        Console.Write("Enter the mortgage amount: ");
                        double mortgageAmount2 = Convert.ToDouble(Console.ReadLine());

                        // prompt user yearly interest rate
                        Console.Write("Enter the yearly interest rate: ");
                        double yearlyInterestRate2 = Convert.ToDouble(Console.ReadLine());

                        // prompt user customer address
                        Console.Write("Enter the customer address: ");
                        string customerAddress2 = Console.ReadLine();

                        // prompt user business insurance amount
                        Console.Write("Enter the business insurance amount: ");
                        double businessInsuranceAmount2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine();

                        // call class BusinessMortgage
                        BusinessMortgage customer2 = new BusinessMortgage
                            (mortgageNumber2, customerName2, mortgageAmount2,
                             yearlyInterestRate2, customerAddress2, businessInsuranceAmount2);

                        // print customer1 via the class BusinessMortgage
                        Console.WriteLine(customer2);

                        // print CalculateMonthlyMortgageInstallment from the class BusinessMortgage
                        Console.WriteLine("Monthly mortgage installment with " +
                                          "business insurance amount: {0:C}",
                                          customer2.CalculateMonthlyMortgageInstallment());                        break;
                }
            } while (number != "0"); // end loop
        } // end method
    } // end class
} // end namespace
