using System;
using System.Collections.Generic; 
using System.Linq;
using System.Runtime.InteropServices;
using System.Text; 
using System.Threading.Tasks; 

// This program demonstrates various sample coding challenges in C#

namespace cSharpProject
{

    class Program   
    {
        static void Main(string[] args)
        {
            // Challenge 1:
            Console.WriteLine("Please enter a number in the range of 1 to 10:");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice >= 1 && choice <= 10)
            {
                Console.WriteLine(string.Format("Valid entry, you entered {0}", choice));
            }
            else
            {
                Console.WriteLine(string.Format("Invalid entry, you entered {0}", choice));
            }



            // Challenge 2:
            Console.WriteLine("Enter a number here:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number here:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("The larger of the two numbers is: " + num1);
            }
            else
            {
                Console.WriteLine("The larger of the two numbers is: " + num2); 
            }



            // Challenge 3:

        }
    }
}
