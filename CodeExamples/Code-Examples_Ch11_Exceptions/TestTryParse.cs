using System;
class TestTryParse
{   
   static void Main()
   {
      int number;
      Console.Write("Enter an integer >> ");
      if(TryParse(Console.ReadLine(), out number))
         Console.WriteLine("Success!");
      else 
         Console.WriteLine("Failure");  
      Console.WriteLine("The number is " + number);
   }
   private static bool TryParse(string inputString, out int number)
   {
      bool wasSuccessful = true;
      try
      {
         number = Convert.ToInt32(inputString);
      }
      catch(FormatException e)
      {
         wasSuccessful = false;
         number = 0;
      }
      return wasSuccessful;
   }
}