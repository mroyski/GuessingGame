using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int numGuess = 0;

            Random r = new Random();

            int winNum = r.Next(0, 11);

            bool win = false;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10.");
                Console.WriteLine("Enter 0 for instructions.");
                Console.WriteLine("Enter -1 to quit.");
                string s = Console.ReadLine();


                int i = int.Parse(s);


                if (i == 0)
                {
                    Console.WriteLine("==== INSTRUCTIONS ====");
                }
                else if (i == -1)
                {
                    System.Environment.Exit(0);
                }
                else if (i > winNum)
                {
                    Console.WriteLine("Too high! Guess lower.");
                    numGuess++;
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Too low! Guess higher.");
                    numGuess++;
                }
                else if (i == winNum)
                {
                    Console.WriteLine("YOU WIN!");
                    win = true;
                }
                else if (numGuess == 3)
                {
                    Console.WriteLine("You lost. Bye sucka!");
                    System.Environment.Exit(0);
                }

                Console.WriteLine();
            } while (win == false);

            Console.WriteLine("Thank you for playing the game!");
            //Console.Write("Press any key to finish.");
            //Console.ReadKey(true);
        }
    }
}

