using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{
    internal class ThreeAmigos
    {
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void ByThrees()
        {
            var triples = 999;
            for (int i = 0; i <= triples; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
