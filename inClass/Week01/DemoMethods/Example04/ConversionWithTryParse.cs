using System;

namespace Example04
{
    class ConversionWithTryParse
    {
        public static void Main(string[] args)
        {
            string entryString;
            int score;
            Console.Write("Enter your test score >> ");
            entryString = Console.ReadLine();
            int.TryParse(entryString, out score);
            Console.WriteLine("You entered {0}", score);
        }
    }
}
