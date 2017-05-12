using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpProject
{
    public class Calculator
    {
        // Since this below method is static, its accessible by all classes in the program
        // To use it, you dont need to create an instance object of the Calculator class, 
        // all you have to do is use the class name directly and access this method
        // Ex. Calculator.Add(1, 2); 
        public static int Add(int a, int b)
        {
            return a + b; 
        }
    }
}
