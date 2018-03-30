using System;
namespace Exercise02
{
    class GirlScout : Salesperson, ISellable
    {
        // properties
        public int NumberOfCookieBoxesSold { get; set; } = 0;

        // constructors
        public GirlScout(string firstName, string lastName)
            : base(firstName, lastName)
        { }

        // methods
        public void SalesSpeech()
        {
            Console.WriteLine("Hello! My name is {0}, I sell the best cookies " +
                              "in the city. Are you willing to buy some " +
                              "boxes of cookies?", Fullname());
        } // end SalesSpeech
        public void MakeSale(int boxesSold)
        {
            NumberOfCookieBoxesSold += boxesSold;
        } // end MakeSale

        // displaying datas
        public override string ToString()
        {
            return string.Format("{0} \nNumber of Cookie Boxes Sold: {1}",
                                 base.ToString(), NumberOfCookieBoxesSold);
        } // end ToString
    } // end class
} // end namespace
