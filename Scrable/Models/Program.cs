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
      string ScrableWord = ScrableWords.ToLower();
      char [] ScrableWordArray = ScrableWord.ToCharArray();
      int TotalValue=0;
      for (int i=0; i<ScrableWordArray.Length; i++)
      {
        for (int j=1; j<MyWord.ValueContainer.Count+1;j++)
        {
          if (MyWord.ValueContainer[j].Contains(ScrableWordArray[i]))
          {
            if (j<6)
            {
              TotalValue +=j ;
            }
            else if(j==6)
            {
              TotalValue +=8;
            }
            else if (j==7)
            {
              TotalValue +=10;
            }
              
          }
        }
      }
      Console.WriteLine($"Here is the answer{TotalValue}");

          



    }
  }
}