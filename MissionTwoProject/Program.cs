//Lillie Heath
//Section 4 Group 2

using System;

namespace MissionTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new instance for Print class
            Print pf = new Print();

            //start program and initiate numRolls
            Console.WriteLine("Welcome to the dice throwing simulator! \n");
            int numRolls = 0;

            //get number from user and convert it to int
            Console.Write("How many dice rolls would you like to simulate?: ");
            numRolls = int.Parse(Console.ReadLine());

            //call Print class and pass numRolls through
            pf.PrintExplanation(numRolls);

            //create new random instance
            Random r = new Random();

            //set up 12 spots in array
            int[] rollResults = new int[12];

            //generate 2 random numbers and push it to the array
            for (int i = 0; i < numRolls; i++)
            {
                rollResults[r.Next(6) + r.Next(6)]++;
            }

            //print out results for each number 2-12
            for (int i = 0; i < 11; i++)
            {
                int diceNum = i + 2;
                string ast = "";
                double resultPercent = (double)rollResults[i] * 0.1;
                //Console.WriteLine(resultPercent);
                while (resultPercent >= 1)
                {
                    ast = ast + "*";
                    resultPercent--;
                }
                Console.WriteLine(diceNum + ": " + ast);
            }
            //end program
            Console.WriteLine("\n Thank you for using the dice throwing simulator.  Goodbye!");

        }


    } //end class
}
