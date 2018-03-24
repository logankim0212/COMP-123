using System;

namespace Example02
{
    public class ParameterDemo2
    {
        public static void Main(string[] args)
        {
            int x = 4;
            Console.WriteLine("In Main x is {0}", x);
            DisplayReferenceParameter(ref x);
            Console.WriteLine("In Main x is {0}", x);
            int a = 10, b = 20;
            Console.WriteLine("Before method call, a is {0}", a);
            Console.WriteLine("Before method call, b is {0}", b);
            Swap(ref a, ref b);
            Console.WriteLine("After method call, a is {0}", a);
            Console.WriteLine("After method call, b is {0}", b);

        }
        static void DisplayReferenceParameter(ref int number)
        {
            number = 888;
            Console.WriteLine("In method, number is {0}", number);
        }
        static void Swap(ref int number1, ref int number2)
        {
            number1 = 20;
            number2 = 10;
            Console.WriteLine("In method, number1 is {0}", number1);
            Console.WriteLine("In method, number2 is {0}", number2);
        }
    }
}