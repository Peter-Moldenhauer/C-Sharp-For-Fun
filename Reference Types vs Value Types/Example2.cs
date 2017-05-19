using System;
using System.Collections.Generic; 
using System.Linq;
using System.Runtime.InteropServices;
using System.Text; 
using System.Threading.Tasks; 

// This program demonstrates reference types vs. value types 

namespace cSharpProject
{

    public class PersonClass
    {
        public int age;
    }

    class Program   
    {
        static void Main(string[] args)
        {
            // VALUE TYPE EXAMPLE

            var number = 1;
            Increment(number); // call increment method and pass the number variable that was just created 
            // Note: the number var (line 22) stays at the value of 1 because a copy of this variable is passed
            // Therefore, the copy changes to 11 but number stays at 1
            Console.WriteLine(number); // prints: 1


            // REFERENCE TYPE EXAMPLE (using the PersonClass defined above)

            var personA = new PersonClass() {age = 20}; // create a PersonClass object
            MakeOld(personA); // personA is passed by reference and therefore the age value WILL change when modified in the method
            Console.WriteLine(personA.age);  // prints: 30
        }



        // methods outside of main, set to static just for ease so I don't have to create objects of them 
        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(PersonClass person1)
        {
            person1.age += 10; 
        }
    }
}
