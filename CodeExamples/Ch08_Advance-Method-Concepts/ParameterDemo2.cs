using System;
public class ParameterDemo2
{
   static void Main()
   {
      int x = 4;
      Console.WriteLine("In Main x is {0}", x);
      DisplayReferenceParameter(ref x);  
      Console.WriteLine("In Main x is {0}", x);
   }
   private static void DisplayReferenceParameter(ref int number)  
   {
      number = 888;
      Console.WriteLine("In method, number is {0}",
         number);
   }
}
