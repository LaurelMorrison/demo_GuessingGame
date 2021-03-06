using System;

class Program
{
    static void Main()
    {
        bool difficultyCheck = true;
        int allowedGuesses = 0;
        int DifficultyLevel = 0;
        int guess = 0;
        int randomNumber = new Random().Next(1, 100);
        int EasyLevel = 1;
        int MediumLevel = 2;
        int HardLevel = 3;
        int CheaterLevel = 4;

        while (difficultyCheck)
        {
            Console.Write(@"what difficulty level would you like? 
        1. Easy
        2. Medium
        3. Hard
        4. Cheater
        "
            );

            DifficultyLevel = int.Parse(Console.ReadLine());
            if (DifficultyLevel == EasyLevel)
            {
                allowedGuesses = 8;
                difficultyCheck = false;
            }
            else if (DifficultyLevel == MediumLevel)
            {
                allowedGuesses = 6;
                difficultyCheck = false;
            }
            else if (DifficultyLevel == HardLevel)
            {
                allowedGuesses = 4;
                difficultyCheck = false;
            }
            else if (DifficultyLevel == CheaterLevel)
            {
                allowedGuesses = int.MaxValue;
                difficultyCheck = false;
            }
            else
            {
                Console.WriteLine("Invalid response, please enter easy, medium or hard");
            };
        }

        for (int i = 1; i <= allowedGuesses; i++)
        {
            Console.Write("Guess a secret number between 1-100 ");
            try
            {
                guess = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid guess");
                i--;
                Console.Write($"You have {allowedGuesses - i} tries left. Enter another number: ");
                continue;
            };

            if (guess == randomNumber)
            {
                Console.WriteLine("Your guess was correct!");
                Console.Beep();
                break;
            }
            if (guess > randomNumber)
            {
                Console.WriteLine("Your guess was too high");
            }
            if (guess < randomNumber)
            {
                Console.WriteLine("Your guess was too low");
            }
            if (allowedGuesses == i)
            {
                Console.WriteLine($"The number was: {randomNumber}");
                break;
            }
            if (DifficultyLevel != CheaterLevel)
            {
                Console.Write($"You have {allowedGuesses - i} tries left. Enter another number: ");
            }

        }
    }
}