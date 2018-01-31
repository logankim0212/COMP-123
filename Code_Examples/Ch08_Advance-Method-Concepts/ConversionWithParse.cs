using System;
class ConversionWithParse
{
   static void Main()
   {
      string entryString;
      int score;
      Console.Write("Enter your test score >> ");
      entryString = Console.ReadLine();
      score = int.Parse(entryString);
      Console.WriteLine("You entered {0}", score);
   }
}
