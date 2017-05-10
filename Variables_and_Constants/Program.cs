using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 


// This program demonstrates using variables and constants


namespace cSharpProject
{
    class Program   
    {
         
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;  // To treat this as a float, remember the f after the number!
            char character = 'A'; // enclose characters with single quotes
            string firstName = "Peter"; // enclose strings with double quotes 
            bool isWorking = true; 

            Console.WriteLine(number); 

            // To display all of the variables above, use a "code snippit"
            // Start by typing cw and then push tab, the cw will turn into Console.WriteLine();

            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            // Now, to make things easier, in C# there is a keyword called var - this makes 
            // variable declarations easier. 
            // So above, instead of explicitly typing out the data types before the variables, you 
            // can simply type var. The C# compiler will then detect the data type for the variable. 

            var number2 = 2;
            var count2 = 10;
            var totalPrice2 = 20.95f;
            var character2 = 'A';
            var firstName2 = "Peter";
            var isWorking2 = true;


            // Example below is of a format string, similar to printf() in C
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); // this will print: 0 255


            // Example of declaring a constant (specifically a constant float) below...
            const float Pi = 3.14f; 
        }
    }
}
