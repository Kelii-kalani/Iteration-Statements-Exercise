using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{
    internal class EqualsWins
    {   //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void DiceGame()
        {
            var r = new Random();
            var dieNumber1 = r.Next(1, 6);
            var dieNumber2 = r.Next(1, 6);

            do { 
                Console.WriteLine("To roll your dice press enter");
                Console.ReadLine();

                dieNumber1 = r.Next(1, 6);
                dieNumber2 = r.Next(1, 6);
                Console.WriteLine(dieNumber1);

                Console.WriteLine(dieNumber2);

            
                if (dieNumber1 == dieNumber2)
                {
                    Console.WriteLine($"{dieNumber1} is equal to {dieNumber2} Winner");
                }
                else
                {
                    Console.WriteLine($"{dieNumber1} and {dieNumber2} are odd Try again");
                    
                }
            } while(dieNumber1 != dieNumber2);               
        }
    }
}
