using System;
namespace Exercise02
{
    class RealEstateSalesperson : Salesperson, ISellable
    {
        // instant data members
        private double commissionRate;

        // properties
        public double TotalValueSold { get; set; } = 0;
        public double TotalCommissionEarned { get; set; } = 0;
        public double CommissionRate
        {
            get
            {
                return commissionRate;
            } // end get
            set
            {
                // validation
                if (commissionRate >= 0)
                {
                    commissionRate = value;
                }
                else
                {
                    Console.WriteLine("Comission rate should not be negative.");
                }
            } // end set
        } // end CommissionRate

        // constructors
        public RealEstateSalesperson(string firstName, string lastName, double commissionRate)
            : base(firstName, lastName)
        {
            CommissionRate = commissionRate;
        }

        // methods
        public void SalesSpeech()
        {
            Console.WriteLine("Hello! My name is {0}. I sell the best house " +
                              "in the city. How can I help you?", Fullname());
        } // end SalesSpeech
        public void MakeSale(int houseValue)
        {
            TotalValueSold += houseValue;
            TotalCommissionEarned += houseValue * (CommissionRate / 100);
        } // end MakeSale

        // displaying datas
        public override string ToString()
        {
            return string.Format("{0} \nTotal Value Sold: {1:C} \nTotal " +
                                 "Commission Earned: {2:C}", base.ToString(),
                                 TotalValueSold, TotalCommissionEarned);
        } // end ToString
    } // end class
} // end namespace
