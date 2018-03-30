using System;
namespace Exercise01
{
    abstract public class Package
    {
        // instant data members
        private int packageWeight;
        private double ratePerGram;

        // properties
        public string PackageId { get; set; }
        public string SenderName { get; set; }
        public string SenderAddress { get; set; }
        public int PackageWeight
        {
            get
            {
                return packageWeight;
            } // end get
            set
            {
                // validation
                if (packageWeight >= 0)
                {
                    packageWeight = value;
                }
                else
                {
                    Console.WriteLine("Package weight should not be negative.");
                }
            } // end set
        } // end PackageWeight
        public double RatePerGram
        {
            get
            {
                return ratePerGram;
            } // end get
            set
            {
                // validation
                if (ratePerGram >= 0)
                {
                    ratePerGram = value;
                }
                else
                {
                    Console.WriteLine("Rate per gram should not be negative.");
                }
            } // end set
        } // end RatePerGram

        // constructors
        public Package(string packageId, string senderName,
                string senderAddress, int packageWeight, double ratePerGram)
        {
            PackageId = packageId;
            SenderName = senderName;
            SenderAddress = senderAddress;
            PackageWeight = packageWeight;
            RatePerGram = ratePerGram;
        } // end constructors

        // abstract method
        public abstract double CalculatePackageCost();

        // displaying datas
        public override string ToString()
        {
            return string.Format("Package Id: {0} \nSender Name: {1} " +
                                 "\nSender Address: {2} \nPackage Weight: {3:F}g" +
                                 "\nRate Per Gram: {4:C}", PackageId, SenderName,
                                 SenderAddress, packageWeight, RatePerGram);
        } // end ToString
    } // end class
} // end namespace
