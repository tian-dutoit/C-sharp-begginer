﻿using System;
using System.Collections.Generic;


namespace C_sharp_begginer
{
    class Program
    {
        public class Conditionals {
            // 1- Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)
            public static void ExcerciseOne(){
                System.Console.WriteLine("Please enter a number between 1 and 10");
                var number = Convert.ToInt32(Console.ReadLine());        
                if (number > 0 && number < 11)
                {
                    System.Console.WriteLine("Valid");
                } else
                {
                    System.Console.WriteLine("Invalid");
                }  
            }

            // 2- Write a program which takes two numbers from the console and displays the maximum of the two.

            public static void ExcerciseTwo(){
                System.Console.WriteLine("Please enter a number");
                var first = Int32.Parse(Console.ReadLine());
                System.Console.WriteLine("Please enter another number");
                var second = Int32.Parse(Console.ReadLine());
                    if (first > second) 
                {
                    System.Console.WriteLine(first);
                } else
                {
                    System.Console.WriteLine(second);
                }      
            }

            // 3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
            public static void ExcerciseThree(){
                 System.Console.WriteLine("Please enter the width of the image");
                var width = Int32.Parse(Console.ReadLine());
                System.Console.WriteLine("Please enter the height of of the image");
                var height = Int32.Parse(Console.ReadLine());
                    if (width > height) 
                {
                    System.Console.WriteLine("The image is landscape");
                } else
                {
                    System.Console.WriteLine("The image is portrait");
                } 
            }

            // 4- Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.
              public static void ExcerciseFour(){
                 System.Console.WriteLine("Please enter the speed limit");
                var limit = Int32.Parse(Console.ReadLine());
                System.Console.WriteLine("Please enter the speed of the car");
                var speed = Int32.Parse(Console.ReadLine());
                    if (speed < limit) 
                {
                    System.Console.WriteLine("Ok");
                } else
                {
                   var over = (speed - limit)/5;
                   if (over < 12) {
                    System.Console.WriteLine("You have earned {0} demerit points", over);
                   }
                   else {
                       System.Console.WriteLine("License Suspended");
                   }
                } 
            }
        }

        public class Loops {
            //  Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
            public static void ExcerciseOne(){
                var count = 0;
                for (int i = 0; i < 100; i++)
                {
                    if (i%3 == 0)
                    {
                        count ++;
                    }
                }
                System.Console.WriteLine(count);
            }           
            
            // 2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
            public static void ExcerciseTwo(){
                var sum = 0;
                while (true)
                {
                    System.Console.WriteLine("Please enter a number or type 'ok' to exit");
                    var input = Console.ReadLine();
                    if(input == "ok") {
                        break;
                    } else
                    {
                        sum += Convert.ToInt32(input);   
                    }                    
                }
                System.Console.WriteLine(sum);
            } 


            // 3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            public static void ExcerciseThree(){
                var sum = 1;
                System.Console.WriteLine("Please enter a number");
                var number = Convert.ToInt32(Console.ReadLine());
                for (int i = number; i > 0; i--)
                {
                    sum *= i;
                }
                System.Console.WriteLine("{}! = {}", number, sum);
            }


            // 4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)
            public static void ExcerciseFour(){
                var secret = new Random().Next(1, 10);

                for (int i = 0; i < 4; i++)
                {
                    System.Console.WriteLine("Guess the secret number between one and ten");
                    var guess = Convert.ToInt32(Console.ReadLine());
                    if (guess == secret)
                    {
                        System.Console.WriteLine("You won");
                        return; //get out of loop if they are correct
                    }
                }
                System.Console.WriteLine("You lost");
            }


            // 5- Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
            public static void ExcerciseFive(){
                System.Console.WriteLine("Please enter a series of numbers separated by commas");
                var input = Console.ReadLine();
                var numbers = input.Split(',');
                var maximum = 0;
                foreach (var stringNumber in numbers)
                {
                    var number = Convert.ToInt32(stringNumber);
                    if (number > maximum)
                    {
                        maximum = number;
                    }
                }
                System.Console.WriteLine(maximum);
            }

        
        }
         public class ArraysAndLists {

            // 1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

            //     If no one likes your post, it doesn't display anything.
            //     If only one person likes your post, it displays: [Friend's Name] likes your post.
            //     If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            //     If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.

            // Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
             public static void ExcerciseOne(){
                 var names = new List<string>();
                 while (true)
                 {
                     System.Console.WriteLine("Please enter a name or press Enter to finish");
                     var input = Console.ReadLine();
                     if (String.IsNullOrWhiteSpace(input))
                     {
                        break; 
                     } else
                     {
                        names.Add(input);
                     }
                 }

                 // if/else probably a better way to go
                 switch (names.Count)
                 {
                     case 0: System.Console.WriteLine();     
                     break;                
                     case 1: System.Console.WriteLine("{0} likes your post", names[0]);
                     break;
                     case 2: System.Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
                     break;
                     default: System.Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count-2);
                     break;
                 }
             }

            //  2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.
             public static void ExcerciseTwo(){
                 System.Console.WriteLine("Please enter your name");
                 var input = Console.ReadLine();
                 var nameArray = new char[input.Length];
                  for (int i = nameArray.Length; i > 0; i--)
                  {
                      nameArray[nameArray.Length - i] = input[i - 1];
                  }
                  
                var reversed = new string(nameArray); 
                Console.WriteLine("Reversed name: " + reversed);
             }

            //  3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
             public static void ExcerciseThree(){             
                 var numbers = new List<int>();
                 var count = 0;
                 while(count < 5)
                 {
                     System.Console.WriteLine("Please enter five unique numbers, one at a time");
                     var input = Convert.ToInt32(Console.ReadLine());   
                    if (numbers.Contains(input))
                    {
                        System.Console.WriteLine("Please enter a unique number");
                        continue;
                    } else
                    {
                        numbers.Add(input);
                        count ++;
                    }
                      
                 }
                 numbers.Sort();
                System.Console.WriteLine(numbers);
             }

             // 4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.
             public static void ExcerciseFour(){
                 var numbers = new List<int>();
                  while (true)
                  {
                    System.Console.WriteLine("Please enter a number or type Quit to exit");
                    var input = Console.ReadLine();     
                    if (input.ToLower() == "quit")
                    {
                        break;
                    } else
                    {
                        var number = Convert.ToInt32(input);
                        numbers.Add(number);
                    }                 
                  }  
                    var uniqueNumbers = new List<int>();
                    foreach (var number in numbers)
                    {
                        if (!uniqueNumbers.Contains(number))
                        {
                            uniqueNumbers.Add(number);
                        }
                    }
                    System.Console.WriteLine(uniqueNumbers);
             }
             
             // 5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list. 
             public static void ExcerciseFive(){
                 var numbers = new List<int>();
                 System.Console.WriteLine("Please enter a list of comma separated numbers (e.g 5, 1, 9, 2, 10).");
                 var input = Console.ReadLine();
                 var inputArr = input.Split(",");

                 if (inputArr.Length < 5)
                 {
                     System.Console.WriteLine("Invalid List, please try again");
                 }
                 else {
                     foreach (var number in inputArr)
                {
                    numbers.Add(Convert.ToInt32(number));
                }
                numbers.Sort();
                System.Console.WriteLine("{0}, {1} and {3} are the smallest numbers of the list", numbers[0], numbers[1], numbers[2]);
                 }       
             }
         }
        static void Main(string[] args)
        {
            Conditionals.ExcerciseOne();
           
        }
    }
}
