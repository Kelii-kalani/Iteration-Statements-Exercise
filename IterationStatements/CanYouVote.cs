using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{
    internal class CanYouVote
    {   //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void Voter()
        {
            int x;
            bool votersAge;

            do
            {
                Console.WriteLine("What is your age?");
                votersAge = int.TryParse(Console.ReadLine(), out x);
                

                if (x >= 18)
                {
                    Console.WriteLine("You can vote!!");
                }
                else if (x < 18 && x > 0)
                {
                    Console.WriteLine("You can not vote sorry. Come back when your 18.");
                }
                else
                {
                    Console.WriteLine("Invalid entry, try again");
                }
            } 
            while (votersAge == false);
        }
    }
}
