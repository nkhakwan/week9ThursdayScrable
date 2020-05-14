using System;
using System.Collections.Generic;

namespace WordValue{
  public class MyWord
  {

    public static List<char> OneV = new List<char>{'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'};
    public static List<char> TwoV = new List<char>{'d', 'g'};
    public static List<char> ThreeV = new List<char>{'b','c','m','p'};
    public static List<char> FourV = new List<char>{'f','h','v','w','y'};
    public static List<char> FiveV = new List<char>{'k'};
    public static List<char> EightV = new List<char>{'j','x'};
    public static List<char> TenV = new List<char>{'q','z'};
    public static Dictionary<int,string> ValueContainer= new Dictionary <int,string> { {1,"aeioulnrst"}, {2,"dg"}, {3,"bcmp"}, {4, "fhvwy"},{5, "k"},{6,"jx"},{7,"qz"} };


  }
}


