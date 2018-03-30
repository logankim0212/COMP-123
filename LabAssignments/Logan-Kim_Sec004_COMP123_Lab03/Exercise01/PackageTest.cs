using System;

namespace Exercise01
{
    class PackageTest
    {
        public static void Main(params string[] args)
        {
            // TwoDayPackage
            TwoDayPackage customer1 = new TwoDayPackage("123456789", "Logan Kim",
                                                        "2 Fernwood Crt.", 1000, 0.2, 5.0);
            Console.WriteLine(customer1);
            Console.WriteLine("Total package cost: {0:C}", customer1.CalculatePackageCost());
           
            Console.WriteLine();

            // OverNightPackage
            OverNightPackage customer2 = new OverNightPackage("987654321", "Donald Trump",
                                                              "10101 Yonge St.", 2000, 0.3);
            Console.WriteLine(customer2);
            Console.WriteLine("Total package cost: {0:C}", customer2.CalculatePackageCost());

        }
    }
}
