using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess a number between 1 and 10, or enter 0 for HELP.");
            string userGuess = Console.ReadLine();

            if (userGuess.Equals("0"))
            {
                Console.WriteLine("===== INSTRUCTIONS =====");
                Console.WriteLine("Guess a number between 1 and 10.");
                Console.WriteLine("Hit enter to submit your guess.");

                userGuess = Console.ReadLine();
            }



            Console.WriteLine("You guessed: " + userGuess);

            if (userGuess.Equals("7"))
            {
                Console.WriteLine("You win!");
            } else
            {
                Console.WriteLine("You lost.");
            }



            //switch Attempt
            //switch (userGuess)
            //{
            //    case "7":
            //        Console.WriteLine("You win!");
            //        break;
            //    case "0":
            //        Console.WriteLine("Please guess a number between 1 and 10.");
            //        break;
            //    default:
            //        Console.WriteLine("Try again.");
            //        break;
            //}
        }
    }
}
