using System;

namespace cSharpProject
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("Hello! My name is " + FirstName + " " + LastName);
        }
    }
}