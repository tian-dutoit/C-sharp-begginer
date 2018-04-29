using System;

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
        static void Main(string[] args)
        {
            Conditionals.ExcerciseOne();
           
        }
    }
}
