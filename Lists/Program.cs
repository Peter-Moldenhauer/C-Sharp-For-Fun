using System;
using System.Collections.Generic; 
using System.Linq;
using System.Runtime.InteropServices;
using System.Text; 
using System.Threading.Tasks; 

// This program demonstrates Lists in C#

// Note: arrays in C# have a fixed size, once created, the size cannot be changed.
// Lists in C# are similar to arrays (data structure for storing data of same type) but lists are dynamic sized
// Use a list if you do not know ahead of time how many objects will be stored in it 
// How to create a list: var numbers = new List<int>(); 

// Note: the angled brackets < > indicates a "generic type" - inside of which you put the type of data the list will hold


namespace cSharpProject
{

    class Program   
    {
        static void Main(string[] args)
        {
            // create a list
            var numbers = new List<int>() {1, 2, 3, 4};

            // add another element to the list
            numbers.Add(9); 

            // add more than 1 element to list using AddRange (adds another list or an array to the list) 
            numbers.AddRange(new int[3] {32, 33, 34}); // create an array to add to the list 

            // print out list to console 
            foreach (var number in numbers)
            {
                Console.WriteLine(number);  // prints 1 2 3 4 9 32 33 34 
            }

            // IndexOf() method - retruns index of given value or -1 if not found
            Console.WriteLine("Index of 9: " + numbers.IndexOf(9));

            // Count - a property that returns the number of objects in the list
            Console.WriteLine("Count: " + numbers.Count);  // prints 8

            // remove() method, example 1 - remove the first occurance of a given value
            numbers.Remove(2);

            // print to screen...
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


            // remove() example 2 - remove ALL occurances of a given value 
            numbers.Add(9);  // add another occurance of 9 as the last element
            for(int i = 0; i < numbers.Count; i++)  // Note: use a for loop NOT a foreach loop here! - will get an error
            {
                if (numbers[i] == 9)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            // print to screen...
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // clear() method - removes all elements from the list
            numbers.Clear();
            // now, count will be displayed as 0 because the list was cleared
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}
