using System;
using System.Collections.Generic;
using System.Text;


namespace C_sharp_begginer
{
  public class StringExercise {

    // 1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
    static void exerciseOne () {
      var numbers = new List<int>();
      System.Console.WriteLine("Please enter some numbers separated by hyphens (e.g. 5-6-7-8-9)");
      var input = Console.ReadLine();
      if(String.IsNullOrWhiteSpace(input)) {
        System.Console.WriteLine("Invalid entry");
      } else
      {
        var stringArr = input.Split(' ');
        foreach (var str in stringArr)
        {
            numbers.Add(Convert.ToInt32(str));
        }
        var consecutive = true;
        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] != (numbers[i-1] + 1))
            {
                consecutive = false;
            }
        }
        var display = consecutive ? "Consecutive" : "Not Consecutive";
         System.Console.WriteLine(display);
      }
    }

    //2- Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

     static void exerciseTwo () {
       var numbers = new List<int>();
      System.Console.WriteLine("Please enter some numbers separated by hyphens (e.g. 5-6-7-8-9)");
      var input = Console.ReadLine();
      if(String.IsNullOrWhiteSpace(input)) {
        System.Console.WriteLine("Invalid entry");
        return;
      } else {
          var stringArr = input.Split(' ');
          foreach (var str in stringArr)
          {
            numbers.Add(Convert.ToInt32(str));
           }
          numbers.Sort();
          for (int i = 1; i < numbers.Count; i++)
          {
            if (numbers[i] == numbers[i-1])
            {
                System.Console.WriteLine("Duplicate");
                break;
            }
        }
      }  
    }   

    // 3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.

     static void exerciseThree () {
       System.Console.WriteLine("Please enter a time in 24 hour format (e.g. 15:00");
       var input = Console.ReadLine();
       if (String.IsNullOrWhiteSpace(input))
       {
          System.Console.WriteLine("Invalid Time");           
          return;
       }
       //Go back to the time lectures
    }

    // 4- Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents". 

     static void exerciseFour () {
       System.Console.WriteLine("Please enter a few words separated by a space");
       var input = Console.ReadLine();
       var variableName = "";
       foreach (var word in input.Split(' '))
       {
           var wordWithPascalCase = char.ToUpper(word[0]) +  word.ToLower().Substring(1);
           variableName += wordWithPascalCase;
       }
      Console.WriteLine(variableName);
    }
    
    // 5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.

     static void exerciseFive () {
       System.Console.WriteLine("Please enter a word");
       var input = Console.ReadLine().ToLower(); //don't have to check for both capital and lowercase
       var count = 0;
       foreach (var character in input)
       {
         if (character == 'a' && character == 'e' && character == 'i' && character == 'o' && character == 'u')
         {
             count ++;
         }           
       }
      System.Console.WriteLine(count);
    }
  }
}