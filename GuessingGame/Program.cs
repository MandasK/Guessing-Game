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
            int GuessedNumber = Convert.ToInt32(Console.ReadLine());

            int playerChance = 0;
            int secretNumber = 42;

            while (playerChance < 3)
            {
                if (GuessedNumber == secretNumber)
                {
                    Console.WriteLine("You guessed right and you know the secret to life!");
                    break;
                }
                else if (GuessedNumber != secretNumber)
                {
                    ++playerChance;
                    Console.WriteLine("You guessed wrong. BOOOOO!");
                    Console.Beep(100, 400);
                    Console.Beep(150, 1600);
                    Console.WriteLine($"Would you like to try again? Guess({playerChance + 1})");
                    GuessedNumber = Convert.ToInt32(Console.ReadLine());

                };
            }
        }
    }
}