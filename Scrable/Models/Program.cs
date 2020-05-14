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
      char [] ScrableWordArray = ScrableWord.ToCharArray();
      Console.WriteLine($"here is our firstArray {ScrableWordArray[0]}");

      if (MyWord.ValueContainer[1].Contains(ScrableWordArray[0]))
      {
          Console.WriteLine("Yes");
      }
      else
      {
        Console.WriteLine("No");
      }
      //for (int i=0; i<ScrableWordArray.Length; i++)
      //{

          // if(MyWord.OneV.Contains(ScrableWordArray[0]))
          // {
          //   Console.WriteLine("yes");
          // }
          // else
          // {
          //   Console.WriteLine("no");
          // }

      // }



    }
  }
}