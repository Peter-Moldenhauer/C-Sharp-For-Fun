using System;
using System.Collections.Generic; 
using System.Linq;
using System.Runtime.InteropServices;
using System.Text; 
using System.Threading.Tasks; 

// This program demonstrates arrays in C#
// An array represents a fixed number of variables of a particular type 
// There are 2 types of arrays in C#
        // single dimension - var numbers = new int[5]; OR var numbers = new int[5] {1, 2, 3, 4, 5} 
        // multi dimension - var matrix = new int[3, 5]; (this is a retangular array with 3 rows and 5 columns in each row
                    // var matrix = new int[3, 5]
                    // {
                    //      { 1, 2, 3, 4, 5},
                    //      { 6, 7, 8, 9, 10},
                    //      { 11, 12, 13, 14, 15}
                    // }; 

                    // var jaggedArray = new int[3][]; (this is a jagged array with 3 rows and different columns in each row)
                    // jaggedArray[0] = new int[4];
                    // jaggedArray[1] = new int[5];
                    // jaggedArray[2] = new int[3]; 

// Note: there are 2 types of multi deminsonal arrays also: rectangular or jagged 

namespace cSharpProject
{

    class Program   
    {
        static void Main(string[] args)
        {
            // create an array of integers named "numbers"
            var numbers = new[] {3, 5, 7, 23, 15, 6};

            // length property of array
            Console.WriteLine("Array length: " + numbers.Length);  // prints: Array length: 6

            // IndexOf() method - use this method to find the position of an element in an array, this method returns an integer
            var indexOf7 = Array.IndexOf(numbers, 7);
            Console.WriteLine("Index of 7: " + indexOf7); // prints: 2 

            // Clear() method - clears a range of elements from a given array
            Array.Clear(numbers, 0, 2);  // this will clear the first 2 elements starting at index 0 
            foreach (var number in numbers) // iterate and print out the array elements, the first 2 will be 0 now
            {
                Console.WriteLine(number);
            }

            // Copy() method - copies a source array to a destination array
            // first desclare another array to copy to...
            int[] anotherArray = new int[3]; // note that this is a smaller array than source, so just copy the first 3 elements from source array
            Array.Copy(numbers, anotherArray, 3);
            foreach (var i in anotherArray) // iterate through and print out contents of anotherArray, prints: 0 0 7 
            {
                Console.WriteLine(i);
            }

            // Sort() method - sorts a given array
            Array.Sort(numbers);
            foreach (var number in numbers) // iterate through and print sorted contents of numbers array
            {
                Console.WriteLine(number); // prints: 0 0 6 7 15 23
            }

            // reverse() method - reverses the order of a given array
            Array.Reverse(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);  // prints: 23 15 7 6 0 0 
            }
        }
    }
}
