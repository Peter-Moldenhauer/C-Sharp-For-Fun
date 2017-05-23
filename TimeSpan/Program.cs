using System;
using System.Collections.Generic; 
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text; 
using System.Threading.Tasks; 

// This program demonstrates the TimeSpan type - this represents a length of time  


namespace cSharpProject
{

    class Program   
    {
        static void Main(string[] args)
        {
            // easy way to create a timespan is to use the new operator
            var timeSpan = new TimeSpan(1, 2, 3);  // 1 hr, 2 mins, 3 secs
            var timeSpan1 = new TimeSpan(1, 0, 0);  // 1 hr, 0 mins, 0 secs

            // A more "Readable" way to create a timespan is to use the static methods on the timespan structure 
            var timeSpan2 = TimeSpan.FromHours(1); // this is another way to say 1 hr, 0 mins, 0 secs, --> like timespan1 variable

            // A 3rd way to create a timespan - if you have 2 DateTime objects and you subtract them, the result is a timespan
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start; // end - start gives us a timespan, in this case the timespan is 2 minutes
            Console.WriteLine("Duration is: " + duration);  // prints: 00:02:00.00000


            // once we have a timespan object, we can read its properties easily 

            Console.WriteLine("Minutes: " + timeSpan.Minutes); // returns the minutes component of the timespan object - in this case it is 2
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes); // converts the timespan object to minutes, returns the total object but in just "minutes units"

            // Note: similar to the datetime object, timespan is immutable - it cannot be changed once created 
            // but there are a few methods to modify its value - add and subtract return a new timespan object

            // add - the add method takes a parameter of type timespan
            Console.WriteLine("Add example: " + timeSpan.Add(TimeSpan.FromMinutes(8))); // added 8 minutes to our original timespan - becomes 1 hr, 10 mins 3 secs
            // subtract
            Console.WriteLine("Subtract example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2))); // subtract 2 minutes from original timespan - becomes 1 hr 0 mins 3 secs

            // Timespan conversion to and from strings...

            // to string - just call the tostring method
            Console.WriteLine("ToString: " + timeSpan.ToString()); 

            // conversion from a string - use parse method
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03")); // returns a timespan object - in this case the object is simply getting printed to the console right away

        }
    }
}
