using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 


// This program demonstrates casting from a string to an int using the Convert class


namespace cSharpProject
{
    class Program   
    {
         
        static void Main(string[] args)
        {
            var number = "1234";
            int i = Convert.ToInt32(number);
            Console.WriteLine(number);

            // Now, if we try to do the same thing and cast it to a byte instead of an int, 
            // it will not work because 1234 will not fit in a byte - the program will crash 
            // due to overflow. 
            // To handle the exception in this case, use a try/catch block of code...

            try
            {
                var number2 = "1234";
                byte b = Convert.ToByte(number2);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

            // The above code snippit will prevent the program from crashing and will print out 
            // the message to the user instead - the string will still not be converted to the byte though
            
            // Another example...

            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The data could not be converted.");
            }

            // In the above example, the string true can be converted to the bool true so 
            // the exception text does NOT execute, instead Console.WriteLine(b) prints true
        }
    }
}
