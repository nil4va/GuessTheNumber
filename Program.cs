using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome to the Guess the Number Game!");
            Console.ResetColor();

            bool playAgain = true;
            while (playAgain)
            {
                PlayGame(random);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Want to play again? (y/n)");
                string answer = Console.ReadLine().ToLower();
                playAgain = answer == "y";
            }

            Console.WriteLine("Thanks for playing! Goodbye!");
        }

        static void PlayGame(Random random)
        {
            int numberToGuess = random.Next(1, 101);
            int attempts = 0;

            Console.WriteLine("Guess the number between 1 and 100!");

            while (true)
            {
                Console.ResetColor();
                string input = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;

                if (int.TryParse(input, out int guessedNumber) && guessedNumber >= 1 && guessedNumber <= 100)
                {
                    attempts++;

                    if (guessedNumber < numberToGuess)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (guessedNumber > numberToGuess)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else if (guessedNumber == numberToGuess)
                    {
                        Console.WriteLine($"🎉 Congratulations! You've guessed the number with {attempts} attempts!");
                        break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                }

                Console.ResetColor();
            }
        }
    }
}
