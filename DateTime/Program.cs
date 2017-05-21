using System;
using System.Collections.Generic; 
using System.Linq;
using System.Runtime.InteropServices;
using System.Text; 
using System.Threading.Tasks; 

// This program demonstrates Date and Time in C#


namespace cSharpProject
{

    class Program   
    {
        static void Main(string[] args)
        {
            // create a DateTime object
            var birthday = new DateTime(1986, 7, 9);

            // To get the current DateTime....
            var currentDate = DateTime.Now;

            // To get the DateTime in perspective of today
            var today = DateTime.Today;

            // Now with all of the above objects, we can access specific parts - year, month, day, minute, hour etc.

            Console.WriteLine("Hour: " + currentDate.Hour);
            Console.WriteLine("Minute: " + currentDate.Minute);

            // Note: DateTime objects in C# are immutable - you CANNOT change them once they are created
            // So how do you change them? --> .Add
            var tomorrow = currentDate.AddDays(1);  // use positive to go in future
            var yesterday = currentDate.AddDays(-1);  // use negative to go in past 

            // Formatting DateTime objects to a string...
            Console.WriteLine(currentDate.ToLongDateString()); // Sunday, May 21, 2017
            Console.WriteLine(currentDate.ToShortDateString()); // 5/21/2017
            Console.WriteLine(currentDate.ToLongTimeString()); // 4:56:17 PM
            Console.WriteLine(currentDate.ToShortTimeString()); // 4:56 PM
            Console.WriteLine(currentDate.ToString()); // 5/21/2017 4:56:17 PM 
            Console.WriteLine(currentDate.ToString("yyy-MM-dd HH:mm")); // 2017-05-21 18:42 - using format spefifier 
        }
    }
}
