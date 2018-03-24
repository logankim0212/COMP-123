using System;

namespace Example01
{
    class MilesPerGallon
    {
        public static void Main(string[] args)
        {
            int milesDriven;
            int gallonsOfGas;
            int mpg;
            try
            {
                Console.Write("Enter miles driven ");
                milesDriven = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter gallons of gas purchased ");
                gallonsOfGas = Convert.ToInt32(Console.ReadLine());
                mpg = milesDriven / gallonsOfGas;
                Console.WriteLine("You got {0} miles per gallon", mpg);
            }
            catch(FormatException)
            {
                Console.WriteLine("One of input value is incorrect.");
                //Console.WriteLine("Error Occured: " + ex.Message);
            } // end catch
            catch (DivideByZeroException)
            {
                Console.WriteLine("User is trying to divide by zero.");
                Console.WriteLine("You cannot divide by zero");
                //Console.WriteLine("Error Occured: " + ex.Message);
            } // end catch
            catch (OverflowException)
            {
                Console.WriteLine("Input value is too big or too small.");
                //Console.WriteLine("Error Occured: " + ex.Message);
            } // end catch
            catch (Exception ex)
            {
                Console.WriteLine("Inside the catch block.");
                Console.WriteLine("Error Occured: " + ex.Message);
            } // end catch
            Console.WriteLine("End of application");
        } // end main
    } // end class
} // end namespace
