using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionTwo
{
    class Print
    {
        public void PrintExplanation(int numRolls)
        {
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS \nEach '*' represents 1% of the total number of rolls. ");
            Console.WriteLine("Total number of rolls = " + numRolls + "\n");
        }

    }
}

