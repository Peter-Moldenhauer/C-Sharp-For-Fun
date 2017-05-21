using System;
using System.Collections.Generic; 
using System.Linq;
using System.Runtime.InteropServices;
using System.Text; 
using System.Threading.Tasks; 

// This program demonstrates the Random class 

namespace cSharpProject
{

    class Program   
    {
        static void Main(string[] args)
        {
            // create an instance of the Random class
            var random = new Random();

            // Example 1
            // random.Next() returns a random integer
            // Here, we use a for loop to generate a few random numbers between 1 and 10 and display to console...
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1, 10));
            }

            // Example 2
            // Generate random numbers 97 - 122 (lowercase ASCII values) to represent random strings used as passwords
            // This will print a random string such as hctpfishen
            for (var i = 0; i < 10; i++)
            {
                Console.Write((char)random.Next(97, 122)); // concole.write (to stay on same line), (char) to cast the random int to a char type
                Console.WriteLine();
            }

            // Example 2 Continued...
            // To actually save the random string (instead of just printing it to the console) we need to 
            // store the result in an array and then create a string based on the array.
            // So, lets modify the above example 2 so that the random string is saved...

            // declare a constant int to hold the password length
            const int passwordLength = 10;

            // Start by declaring a character array
            var buffer = new char[passwordLength]; 

            for (var i = 0; i < passwordLength; i++)
            {
                buffer[i] = ((char)random.Next(97, 122));  // store each random letter in the buffer array
            }

            // turn the buffer (character array) into a string here...
            var password = new string(buffer);

            // Now we can display the string to the console...
            Console.WriteLine("The password is: " + password);
        }
    }
}
