using System;


namespace BisectionAlgo
{
    class Program
    {

        static void userSelection()
        {
            Console.WriteLine("\nMake a selection\n" +
                "\t1. 1-10 bisection search\n" +
                "\t2. User number guess\n" +
                "\t3. Computer challenge");
            try
            {
                int selection = int.Parse(Console.ReadLine());
                if (selection < 1 || selection > 3) throw new FormatException();

                if (selection == 1) Bisection.initiateBisection();
                else if (selection == 2) User.userGuess();
                else if (selection == 3) Computer.initiateComputerGuess();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter 1-3 for a selection");
                userSelection();
            }
            userSelection();
        }
        static void Main(string[] args)
        {
            userSelection();
        }
    }
}
