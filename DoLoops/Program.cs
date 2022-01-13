using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* The Do Loop Statement is similar to the While Statement however there is one difference: in While and For Statements the Boolean expression is at the beginning.
             * In this example we will print out the numbers 10 to 100 to the screen.*/

            int num = 10;

            do
            {
                Console.WriteLine(num);
                num++;
            } while (num < 100);
            Console.ReadLine();

            /* Stepping in and out:
             *
             */

        }
    }
}
