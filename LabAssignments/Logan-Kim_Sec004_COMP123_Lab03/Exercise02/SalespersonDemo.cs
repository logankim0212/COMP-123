using System;

namespace Exercise02
{
    class SalespersonDemo
    {
        public static void Main(string[] args)
        {
            // RealEstateSalesperson
            RealEstateSalesperson realEstate = new RealEstateSalesperson("Logan", "Kim", 5.0);
            realEstate.SalesSpeech();
            realEstate.MakeSale(400000);
            realEstate.MakeSale(1000000);
            Console.WriteLine(realEstate);
            Console.WriteLine();

            // GirlScout
            GirlScout girlScout = new GirlScout("Donald", "Trump");
            girlScout.SalesSpeech();
            girlScout.MakeSale(4);
            girlScout.MakeSale(7);
            Console.WriteLine(girlScout);
            Console.WriteLine();
        } // end Main
    } // end class
} // end namespace
