using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess a number between 1 and 10.");
            string userGuess = Console.ReadLine();
            Console.WriteLine("You guessed: " + userGuess);

            //if (userGuess.Equals("7"))
            //{
            //    Console.WriteLine("You win!");
            //}
            //else if (userGuess.Equals("0"))
            //{
            //    Console.WriteLine("Please guess a number between 1 and 10.");
            //} else
            //{
            //    Console.WriteLine("Try again.");
            //}

            switch (userGuess)
            {
                case "7":
                    Console.WriteLine("You win!");
                    break;
                case "0":
                    Console.WriteLine("Please guess a number between 1 and 10.");
                    break;
                default:
                    Console.WriteLine("Try again.");
                    break;
            }
        }
    }
}
