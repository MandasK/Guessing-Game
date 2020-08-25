using System;
using System.Collections.Generic;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm thinking of a number between 1-100. Guess what the number is correctly and get a PRIZE!");
            Console.Write("What's your guess?");
            string readGuess = Console.ReadLine();
            int GuessedNumber = int.Parse(readGuess);

            int secretNumber = 42;
            if (GuessedNumber == secretNumber)
            {
                Console.WriteLine("You guessed right and you know the secret to life!");
            }
            else
            {
                Console.WriteLine("You guessed wrong. BOOOOO!");
            };
        }
    }
}