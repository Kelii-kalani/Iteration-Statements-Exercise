using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{   //Write a method to check if an integer(from the user) is in the range -10 to 10
    internal class AreYouCool
    {
        public static void CoolMeter()
        {
            Console.WriteLine("Please enter a number positive or negative, I need to know if your cool?");

            var coolness = int.TryParse(Console.ReadLine(), out int entry);

            if (entry > -10 && entry < 10) 
            {
                Console.WriteLine("Yeah you cool");
            }
            else 
            {
                Console.WriteLine("Laaammmeee!!!!");
            }
        }
    }
}
