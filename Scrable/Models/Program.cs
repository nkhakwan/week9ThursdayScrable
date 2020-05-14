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
      int TotalValue=0;
      for (int i=0; i<ScrableWordArray.Length; i++)
      {
        for (int j=1; j<MyWord.ValueContainer.Count+1;j++)
        {
          if (MyWord.ValueContainer[j].Contains(ScrableWordArray[i]))
          {
              TotalValue +=i ;
          }
        }
      }
      Console.WriteLine($"Here is the answer{TotalValue}");

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