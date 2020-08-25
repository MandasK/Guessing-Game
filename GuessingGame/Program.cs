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
            string GuessedNumber = Console.ReadLine();
            Console.WriteLine(GuessedNumber);
        }
    }
}