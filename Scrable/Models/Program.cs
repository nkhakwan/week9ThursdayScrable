using System;
using System.Collections.Generic;

namespace WordValue
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Man enter a word and i'll calculate its scrable value");
      string ScrableWords = Console.ReadLine();
      MyWord MyWordInstance = new MyWord();
      MyWordInstance.CalculateScrable(ScrableWords);
        Console.WriteLine($"Oh Wow you entered {ScrableWords} and the value of {ScrableWords} in Scrable is  {MyWordInstance.TotalValue}");

          



    }
  }
}