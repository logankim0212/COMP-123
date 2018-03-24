using System;

namespace Example05
{
    class ParamsDemo
    {
        static void Main()
        {
            string[] names = { "Mark", "Paulette", "Carol", "James" };
            DisplayStrings("Ginger");
            DisplayStrings("George", "Maria", "Thomas");
            DisplayStrings(names);
            ArrayNumbers(10, 20);
            ArrayNumbers(10, 20, 30);
            ArrayNumbers(10, 20, 30, 40);

        }
        static void ArrayNumbers(params int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write("{0} ", number); 
            }
            Console.WriteLine("\n----------------");
        }
        private static void DisplayStrings(params string[] people)
        {
            foreach (string person in people)
                Console.Write("{0} ", person);
            Console.WriteLine("\n----------------");
        }
    }
}
