using System;
class ParameterDemo1
{
   static void Main()
   {
      int x = 4;
      Console.WriteLine("In Main x is {0}", x);
      DisplayValueParameter(x);
      Console.WriteLine("In Main x is {0}", x);
   }
   private static void DisplayValueParameter(int x)
   {
      x = 777;
      Console.WriteLine("In method, x is {0}", x);
   }
}

