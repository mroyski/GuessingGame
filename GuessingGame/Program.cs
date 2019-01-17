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

            //Convert string to int
            //int numVal = Int32.Parse(userGuess);

            Console.WriteLine("You guessed: " + userGuess);

            if (userGuess.Equals("7"))

            {
                Console.WriteLine("You win!")
            } else
            {
                Console.WriteLine("You lost.");
                Console.WriteLine("Try again.");
                Console.ReadLine();
                {
                    if (userGuess.Equals("7"))
                    {
                        Console.WriteLine("You win!");
                    }
                    else
                    {
                        Console.WriteLine("You lost.");
                    }
                }
            }
        }
    


            //===SWITCH ATTEMPT===
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

