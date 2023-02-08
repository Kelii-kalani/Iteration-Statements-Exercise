using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{
    internal class PowerUpBug
    {   //Write a method to check whether a given number is positive or negative
        public static void ChargeBug()
        {
            Console.WriteLine("Press enter to see if you give power to my bug for battle");
            Console.ReadLine();
            var random = new Random();
            int charge = random.Next(-10, 10);

            Console.WriteLine(charge);

            if (charge > 0)
            {
                 Console.WriteLine("POWERING UP!!!!");
            }
            else if (charge < 0)
            {
                Console.WriteLine("NOOOO!!!! Your taking his power");
            }
            else
            {
                Console.WriteLine("Hahaha you have 0 power");
            }

          
        }
    }
}
