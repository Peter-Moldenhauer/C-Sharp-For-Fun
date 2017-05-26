using System;
using System.Collections.Generic; 
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text; 
using System.Threading.Tasks; 

// This program demonstrates string methods  


namespace cSharpProject
{

    class Program   
    {
        static void Main(string[] args)
        {
            var fullName = "Peter Moldenhauer "; //string variable, Note the space at the end of the string

            // Note: each of these string methods return a new string, they do NOT modify the existing string (strings are immutable!)

            // trim() method - gets rid of whitespace at the beginning or end of a string
            Console.WriteLine("Trim: *{0}*", fullName.Trim()); // Peter Moldenhauer<--ends here

            // toUpper()
            Console.WriteLine("ToUpper: *{0}", fullName.Trim().ToUpper()); // PETER MOLDENHAUER

            // Break the string into first and last name - method 1, look for the index of the space and based on that split the string in 2 parts
            var index = fullName.IndexOf(' '); // find the index of the blank space - split the string based on this index
            var firstName = fullName.Substring(0, index); // firstName substring will go from 0 (start of large string) to index (space in middle of large string)
            var lastName = fullName.Substring(index + 1); // lastname substring will go from index + 1 (first character after the space) to the end of the string
            Console.WriteLine("FirstName: " + firstName); // prints: Peter
            Console.WriteLine("LastName: " + lastName);  // prints: Moldenhauer

            // break string into first and last name - method 2, using the split() method
            var names = fullName.Split(' '); // supply a character or string as an argument, this method returns a string array 
            Console.WriteLine("FirstName: " + names[0]); // prints: Peter
            Console.WriteLine("LastName: " + names[1]); // prints: Moldenhauer

            // replace() method - replace "Peter" with "Rachel" - remember these methods return a NEW string
            Console.WriteLine(fullName.Replace("Peter", "Rachel")); // prints: Rachel Moldenhauer
            // can also replace characters...
            Console.WriteLine(fullName.Replace('e', 'E')); // prints: PEtEr MoldEnhauEr
            

            // How to validate strings - ex. make sure user did indeed enter a credit card number or name
            if(string.IsNullOrEmpty(null))
                Console.WriteLine("Invalid String"); // get "invalid string" because null was passed

            if (string.IsNullOrEmpty(""))
                Console.WriteLine("Invalid String");  // get "invalid string" because an empty string was passed

            // What about if the user enters just a space? Technically it is a string but really it is an "empty string"
            // because it is just a space and not an actual name or credit card number
            // to get around this we need to trim()...
            if (string.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("Invalid String"); // this will also get "invalid string" because we trimed the blank space out and therefore left an empty string

            // Another way to do the same thing...use IsNullOrWhiteSpace...Dont need to use trim() now
            if (string.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid String");


            // How to convert strings to numbers...
            var userAge = "25"; // this is a string, we want to convert it to a number
            // use the Convert class to convert the string
            var age = Convert.ToInt32(userAge); // store the result in the variable "age" 
            Console.WriteLine("Age: " + age);

            // Convert a number to a string...
            float price = 29.95f;
            Console.WriteLine(price.ToString("C")); // use a "format string" as a parameter --> C to represent the "currency format" in intellisence
                // above prints: $29.95
            // Note: above, you could use C0 instead of C, C0 would get rid of the decimal point values (.95) and then round the value and result in: $30 as the string
            
            // Side note: Every object in C# has a .ToString() method! You can call it on anything!!!
        }
    }
}
