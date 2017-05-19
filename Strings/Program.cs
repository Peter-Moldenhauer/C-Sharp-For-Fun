using System;
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 


// This program demonstrates the use of strings


namespace cSharpProject
{

    class Program   
    {
         
        static void Main(string[] args)
        {
             // create some strings - these are string literals 
            string firstName = "Peter";
            string lastName = "Moldenhauer"; 

            // concatenate strings together - 1st way
            string fullName = firstName + " " + lastName;

            // concatenate strings - 2nd way (string format method)
            string myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            // concatenate strings - 3rd way (using string.Join()) 
            var names = new string[3] {"John", "Jack", "Jill"}; // create an array of names
            var formattedNames = string.Join(",", names); // create 1 string of all names, separated by a comma
            Console.WriteLine(formattedNames); // print to screen: John,Jack,Jill 

            // Note: the string.Join() method is a useful technique when you have some values 
            // and you want to combine them together using a sererator 


            // verbatum string - this allows you to type out an exact string without using escape characters
            // so for example, instead of typing out a string like so using \\ to escape \ in a path name...
            // string pathName = "c:\\folder1\\folder2\\document1";
            // You can make it a verbatum string using the @ in front of the first quote...
            string pathName = @"c:\folder1\folder2\document1";
            Console.WriteLine(pathName); 

            // You can even use verbatum strings with newline characters (\n) by just putting test on a new line
            // instead of typing out \n in the middle of the string...
            string text = @"Dear John, 
Thank you for the memmo.
I will follow up tomorrow.
Sincerely, 
Peter";
            Console.WriteLine(text);
        }
    }
}
