using System;
using System.Collections.Generic; 
using System.Linq;
using System.Runtime.InteropServices;
using System.Text; 
using System.Threading.Tasks; 


// This program demonstrates the use of emum


namespace cSharpProject
{
    // Define a new enum here, because its a new type we need to define it at the namespace level 
    //Note: if you dont set values, the 1st value will be 0, 2nd value will be 1, 3rd will be 2..etc...

    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirmail = 2,
        Express = 3
    }

    class Program   
    {
         
        static void Main(string[] args)
        {
            // An enum is a set of name/value pairs (constants) 
            // Note: an enum is internally an integer

            var method = ShippingMethod.Express;
            Console.WriteLine((int) method); // since enum's are basically ints, you can cast it to an int 
                                            // easily so that it can be printed to the screen, prints: 3 

            // You can also convert an int to an enum
            // So if you want to convert an int to a particular ShippingMethod you can do the following...

            var methodID = 3; // define an int, this int will be converted to a shipping method
            Console.WriteLine((ShippingMethod) methodID); // cast the int to ShippingMethod, prints: Express




            // Enums and strings...

            // To convert the above method var (this is an enum variable) to a string, you can use .ToString
            // Note: every object in C# has a method called ToString - since method is an "object" of an emum, we can use this here
            // With the above note, technically you can convert anything to a string without much effort

            Console.WriteLine(method.ToString()); // this will print: Express 

            // Note: console.writeline by default always calls the tostring() on any value you pass to it 
            // Therefore, you don't even need to use the .tostring() as seen below (ONLY IF YOU ARE USING console.writeine)...

            Console.WriteLine(method); // this will print: Express

            // Now, lets convert a string to an emum - to do this we need to parse the string
            // Note: Parsing means to get a string and convert it to a different type
            
            //convert this string to a ShippingMethod enumeration
            var methodName = "Express"; 

            // parse the string to an enum                                           // pass the methodName string to parse
            var myShippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
                               // cast to Shipping Method    // parse to the type of ShippingMethod
            // save the returned
            // object in the myShippingMethod variable 


            // The above code is how you convert a string to an enum!
        }
    }
}
