using System;

namespace Example02
{
    class TwoErrors
    {
        public static void Main(string[] args)
        {
            int num = 2, denom = 10, result;
            int[] array = { 22, 33, 44 };
            try
            {
                result = num / denom;
                result = array[num];
            } // ending
            catch (DivideByZeroException error)
            {
                Console.WriteLine("In first catch block: ");
                Console.WriteLine(error.Message);
            }
            catch (IndexOutOfRangeException error)
            {
                Console.WriteLine("In second catch block: ");
                Console.WriteLine(error.Message);
            }
            finally
            {
                Console.WriteLine("This is finally block");
            }
        }
    }
}
