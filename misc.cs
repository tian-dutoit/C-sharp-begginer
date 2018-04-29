using System;
using System.Collections.Generic;

namespace C_sharp_begginer
{
    class Lists
    {
      public static void FillSpace(){
        var numbers = new List<int>() { 1, 2, 3, 4}; //create and initialize
        numbers.Add(1); // add one
        numbers.AddRange(new int[3] { 5, 6, 7}); //add array at the end
      }
    }
}