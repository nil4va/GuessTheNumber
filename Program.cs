using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int numberToGuess = random.Next(1, 101);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome to the Guess the Number Game!");
            Console.WriteLine("Guess the number between 1 and 100!");
            Console.ResetColor();

            string input = Console.ReadLine();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;

                if (!int.TryParse(input, out int guessedNumber) || guessedNumber < 1 || guessedNumber > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                }
                else if (guessedNumber < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guessedNumber > numberToGuess)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine("🎉 Congratulations! You've guessed the number!");
                    break;
                }
                Console.ResetColor();

                input = Console.ReadLine();
            }

        }
    }
}
