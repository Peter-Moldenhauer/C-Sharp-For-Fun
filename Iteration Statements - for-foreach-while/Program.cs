using System;
using System.Collections.Generic; 
using System.Linq;
using System.Runtime.InteropServices;
using System.Text; 
using System.Threading.Tasks; 

// This program demonstrates iteration (loops) statements in C#
// There are 4 types of iteration statements:
    // for loops
    // foreach loops - used to iterate over elements of a numerical object (anything that has a list or array nature) 
    // while loops
    // do while loops

// Note: "break" will jump out of a loop and "continue" will jump to the next iteration 

namespace cSharpProject
{

    class Program   
    {
        static void Main(string[] args)
        {
            
            // For loop example
            // Display the list of even numbers from 1 to 10
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }


            // For each loop example 1 - iterate over a string (print out each character of string on own line)
            // Note: for each loops are used to iterate over numerical objects such as: strings, lists or arrays
            var name = "John Smith";
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
            // Note: in foreach loops, you dont have to create a counter variable and increment it to name.length

            // Foreach loop example 2 - iterate over an array
            var numbers = new int[] {1, 2, 3, 4};
            foreach (var VARIABLE in numbers)
            {
                Console.WriteLine(VARIABLE);
            }



            // While loop example 1 - same as for loop example above but now we will use a while loop to display even #'s
            // Note: It is better to use a while loop when you dont know ahead of time how many times you will iterate
            var j = 0;
            while (j <= 10)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }
                j++; 
            }

            // While loop example 2
            // Echo back to the screen the string entered, otherwise if ENTER was entered then end the loop
            while (true)
            {
                Console.Write("Type your name: "); // note: write.line will keep cursor on same line (vs. console.writeline)
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))  // could also just use: string.IsNull 
                    break;

                Console.WriteLine("@Echo: " + input); 
            }



        }
    }
}
