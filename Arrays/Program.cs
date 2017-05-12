using System;
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 


// This program demonstrates the use of arrays


namespace cSharpProject
{

    class Program   
    {
         
        static void Main(string[] args)
        {
            // instead of doing this...
            int number1;
            int number2;
            int number3;

            // you can make an array like so...
            int[] numbers = new int[3];

            // you can then access each element like so...
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3; 

            // Instead of the extra steps above, you can initialize the elements all at once...
            // int[] numbers = new int[3] { 1, 2, 3 }; 

            // dsiplay the elements of the array
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            // Another example but using bools...

            var boolArray = new bool[3];
            boolArray[0] = true;

            // Note: only index 0 was initialized, that means 1 and 2 will have the default 
            // initialization of false"
            Console.WriteLine(boolArray[0]);
            Console.WriteLine(boolArray[1]);
            Console.WriteLine(boolArray[2]);

            // Last example using strings and the object initialization syntax
            var names = new string[3] {"Jon", "Jill", "Bob"}; 
        }
    }
}
