using System;
using System.Collections.Generic; 
using System.Linq;
using System.Runtime.InteropServices;
using System.Text; 
using System.Threading.Tasks; 

// This program demonstrates conditional statements 
// In C# there are 3 different ways of writing conditional statements:
        // 1) if/else statements
        // 2) switch/case statements 
        // 3) conditional operator: a ? b : c  (this is a short way of writing an if/else statement)

namespace cSharpProject
{

    public enum Season
    {
        Spring,
        Summer,
        Autum, 
        Winter
    }



    class Program   
    {
        static void Main(string[] args)
        {
            int hour = 10; 

            // Example of if/else statment...
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It is morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It is afternoon."); 
            }
            else
            {
                Console.WriteLine("It is evening.");
            }


            bool isGoldCustomer = true;
            float price;

            // Example of conditional operator...
            price = (isGoldCustomer) ? 19.95f : 29.95f;   // if isGoldCustomer then price is 19.95, if not then price is 29.95

            // You could right the above conditional statement like so...
            // if(isGoldCustomer)
            //      price = 19.95;
            // else
            //      price = 29.95;


            // Example of a switch statement 
            var season = Season.Autum;

            switch (season)
            {
                case Season.Autum:
                    Console.WriteLine("It is autum and a beautiful season.");
                    break;

                case Season.Summer:
                    Console.WriteLine("It is summer and a perfect time to go to the beach.");
                    break;

                default:
                    Console.WriteLine("I don't understand that season.");
                    break; 
            }
        }
    }
}
