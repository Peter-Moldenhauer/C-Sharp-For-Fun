using System;
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 


// This program demonstrates the use of classes 


namespace cSharpProject
{

    class Program   
    {
         
        static void Main(string[] args)
        {
            // Create an instance of the Person class here in the main method
            var pObject = new Person();
            
            // Set the variables in this object
            pObject.FirstName = "Peter";
            pObject.LastName = "Moldenhauer";

            // Call the introduce method of this object
            pObject.Introduce();


            // No need to create an instance of the Calculator class to use the add method
            // this is because the add method is static - so just use the actual class name, 
            // and then access the add method. Again, no need to create an instance object of the class!

            var result = Calculator.Add(5, 10);

            Console.WriteLine("The result of the add method is " + result);
        }
    }
}
