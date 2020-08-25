using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 100);

            int difficultyLevel = 0;

            Console.WriteLine("Welcome to Number Guesser! Please seelct a dificulty: Easy, Medium, or Hard. Or are you a 'cheater'?");
            string level = Console.ReadLine();

            if (level == "easy")
            {
                difficultyLevel = 8;
            }
            else if (level == "medium")
            {
                difficultyLevel = 6;
            }
            else if (level == "hard")
            {
                difficultyLevel = 4;
            }
            else if (level == "cheater")
            {
                difficultyLevel = 100000000;
            }

            for (int i = 0; i < difficultyLevel; i++)
            {
                Console.WriteLine($"I'm thinking of a number between 1-100. Guess what the number is correctly and get a PRIZE! Guesses left: {difficultyLevel - i - 1}");
                Console.Write("What's your guess? ");
                string guess = Console.ReadLine();
                int GuessedNumber = int.Parse(guess);

                if (GuessedNumber == secretNumber)
                {
                    Console.WriteLine("You win! You know the answers to the universe!");
                    Console.Beep(320, 800);
                    Console.Beep(320, 1000);
                    Console.Beep(400, 1200);
                    break;
                }
                else
                {
                    if (GuessedNumber < secretNumber)
                    {
                        Console.WriteLine("Incorrect! The number I am thinking of is higher!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! t he number I am thinking of is lower!");
                    }
                }
            }
        }
    }
}