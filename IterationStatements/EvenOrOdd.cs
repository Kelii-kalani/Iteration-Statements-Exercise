using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{
    internal class EvenOrOdd
    {   //Write a method to check whether a given number is even or odd
        public static void IsIt()
        {   
            Console.WriteLine("Give me a number any number and i can tell you if its even or odd");
            var theChoice = int.Parse(Console.ReadLine());

            if (theChoice % 2 == 0)
            {
                Console.WriteLine("Even!");
            }
            else 
            { 
                Console.WriteLine("Odd!");
            }
        }
    }
}
