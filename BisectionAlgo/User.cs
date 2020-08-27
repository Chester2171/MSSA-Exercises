using System;
using System.Collections.Generic;
using System.Text;

namespace BisectionAlgo
{
    class User
    {
        public static void userGuess()
        {
            int userNumGuess = 0;
            Random random = new Random();
            int computerNumber = random.Next(1, 1001);
            try
            {
                Console.WriteLine("Guess a number between 1 and 1000");
                userNumGuess = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number between 1 and 1000");
                userGuess();
            }
            numbercompare(computerNumber, userNumGuess);
        }
        static void numbercompare(int compNum, int userGuess)
        {
            if (compNum == userGuess) Console.WriteLine("Correct!");
            else if (userGuess > compNum)
            {
                Console.WriteLine("Too High");
                Console.WriteLine("Enter a new guess");
                userGuess = int.Parse(Console.ReadLine());
                numbercompare(compNum, userGuess);
            }
            else if (userGuess < compNum)
            {
                Console.WriteLine("Too Low");
                Console.WriteLine("Enter a new guess");
                userGuess = int.Parse(Console.ReadLine());
                numbercompare(compNum, userGuess);
            }

        }
    }
}
