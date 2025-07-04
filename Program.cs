using System;
using System.Collections.Generic;
using System.Linq;
using GuessTheNumber;

class Program
{
    static void Main(string[] args)
    {
        var game = new Game();
        var random = new Random();
        List<int> scoreboard = [];
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Welcome to the Guess the Number Game!");
        Console.ResetColor();

        bool playAgain = true;
        while (playAgain)
        {
            scoreboard.Add(game.PlayGame(random));

            var top5 = scoreboard.OrderBy(x => x).Take(5)
            .Select((score, index) => $"{index + 1}. {score} attempts");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"⭐️HIGHSCORE⭐️\n{string.Join("\n", top5)}");

            Console.ResetColor();
            Console.WriteLine("Want to play again? (y/n)");
            string answer = Console.ReadLine().ToLower();
            playAgain = answer == "y";
        }

        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}
