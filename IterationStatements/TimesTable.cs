using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{   //Write a method to display the multiplication table(from 1 to 12) of a given integer
    internal class TimesTable
    {
        public static void Clones()
        {   
                int[] syrumY = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
           
                Console.WriteLine("Lets clone you, how many drops of blood are you willing to use?");

                var syrumX = int.Parse(Console.ReadLine());

                Console.WriteLine("Lets mix in some SyrumY");

            foreach (var x in syrumY)
            {
                Console.WriteLine(x * syrumX);
            }    
                Console.WriteLine("This is how many clones you get per shot of SyrumY. So how many clones do you want?");
            
                Console.ReadLine();
                 
                Console.WriteLine("Good choice!");
        }
    }
}
