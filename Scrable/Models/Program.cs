using System;
using System.Collections.Generic;

namespace WordValue
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("enter a word for scrable");
      string ScrableWord = Console.ReadLine();
      Char [] ScrableWordArray = ScrableWord.ToCharArray();
      Console.WriteLine($"here is our firstArray {ScrableWordArray[0]}");
      Console.WriteLine($"here is our firstArray {ScrableWord[0]}");

      



    }
  }
}