using System;
using System.Collections.Generic;

namespace WordValue{
  public class MyWord
  {
    public static Dictionary<int,string> ValueContainer {get; set;}
    public int TotalValue {get; set;}
    public MyWord()
    {
      ValueContainer = new Dictionary <int,string> { {1,"aeioulnrst"}, {2,"dg"}, {3,"bcmp"}, {4, "fhvwy"},{5, "k"},{6,"jx"},{7,"qz"} };
      TotalValue =0;
    }
    
    public void CalculateScrable (string ScrableWords)
    {
      string ScrableWord = ScrableWords.ToLower();
      char [] ScrableWordArray = ScrableWord.ToCharArray();
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
    }
  }
}


