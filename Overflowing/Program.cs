using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 


// This program demonstrates the concept of "overflowing"


namespace cSharpProject
{
    class Program  // every console application you create with Visual Studio has a class called Program 
    {
         
        static void Main(string[] args)
        {
            //Overflowing occurs when you exceed a given data type's capacity
            // In this example the variable is a byte and a byte can hold up to 255
            // therefore, if we add 1 then the result will NOT be 256 (too big!) but actually 0

            // byte number = 255;
            // number = number + 1;  // this will result in 0!

            // To stop overflowing, you need to use the "checked" keyword followed by curly braces which 
            // indicate a code block - inside the code block you put the variable declaration and then 
            // any kind of arithmatic operation
            /*
            
            checked
            {
                byte number = 255;
                number = number + 1;
            }
             
            */

            // With this code (above) overflow will not happen at run time. Instead, an exception will be
            // thrown and the program will crash - unless you handle the exception. 

            // Note: You will probably not use this in real world. Just good to know!
        }
    }
}
