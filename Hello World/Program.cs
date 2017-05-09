// By default, Visual Studio has these 5 using statements 
using System; // System is a namespace in the .NET framework - has utility classes and primitive types
using System.Collections.Generic; // used to work with lists and collections
using System.Linq; // used to work with data
using System.Text; // used to work with text 
using System.Threading.Tasks; // used to build multithreaded applications 

// For this simple Hello World example program, all we are going to use is the System namespace (can clean up the other 4)

namespace cSharpProject
{
    class Program  // every console application you create with Visual Studio has a class called Program 
    {
        // inside Program there is a function called main - this is the entry point to the application 
        // When you run your application, CLR executes the code inside the main function. 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
}
