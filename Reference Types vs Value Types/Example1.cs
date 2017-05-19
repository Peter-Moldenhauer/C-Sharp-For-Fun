using System;
using System.Collections.Generic; 
using System.Linq;
using System.Runtime.InteropServices;
using System.Text; 
using System.Threading.Tasks; 

// This program demonstrates reference types vs. value types 

namespace cSharpProject
{

    class Program   
    {
         
        static void Main(string[] args)
        {
            // VALUE TYPES (int in this example) - create copies of the initial variable (pass by value) 
            var a = 10;
            var b = a; // copy a to b 
            b++; // increment b by 1, the value of a stays at 10 and value of b is 11
            Console.WriteLine(string.Format("a is: {0}, b is: {1}", a, b)); // prints: a is: 10, b is: 11


            // REFERENCE TYPES (array in this example) - a refernce to the initial variable is made (pass by reference)
            var array1 = new int[3] {1, 2, 3};
            var array2 = array1; // copy array1 to array2 
            array2[0] = 0; // modify array 2 - set the first element to 0
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

            // Now, both array1 and array2 has 0 assigned to the first element!
        }
    }
}
