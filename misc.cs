using System;
using System.Collections.Generic;
using System.Text;

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

    class Strings {

      public static void demo () {
        var name = "Tidu ";
        System.Console.WriteLine(name.Trim().ToUpper()); //you can chain the methods

      }

        public static void summariseText () {
          var sentence = "This is a really long sentence but don't let that scare you.";
          const int maxLength = 20;
          if (sentence.Length < maxLength)
          {
              System.Console.WriteLine(sentence);
          } else
          {
              // sentence.Substring(0, maxLength) this will probably cut off a word
              var words = sentence.Split(' ');
              var totalCharacters = 0;
              var summaryWords = new List<string>();
              
              foreach (var word in words)
              {
                totalCharacters += word.Length +1;  
                summaryWords.Add(word);
                if (totalCharacters > maxLength)
                {
                    break;
                }                
              }
              String.Join(" ", summaryWords + "...");
          }
        
      } 
      static void strBuilder() {
        var builder = new StringBuilder();
        builder.Append('-', 10);
        builder.AppendLine();
        builder.Append("Header");
        builder.AppendLine();
        builder.Append('-', 10);
        builder.Replace('-', '+');
        builder.Remove(0, 10);
        // methods can be chained together
      }
    }
}