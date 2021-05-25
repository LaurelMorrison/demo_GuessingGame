using System;

GuessingGame();

static int GuessingGame()
{
    System.Console.Write("Guess a secret number between 1-100");
    int guess = 0;

    try
    {
        guess = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Invalid guess");
        guess = GuessingGame();
    }
    return guess;
}

int allowedGuesses = 3;
int numGuesses = 0;
int randomNumber = new Random().Next(1, 100);

while (true)
{
    int guess = GuessingGame();
    numGuesses++;
    if (guess == randomNumber)
    {
        Console.WriteLine("Your guess was correct!");
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
    if (allowedGuesses == numGuesses)
    {
        Console.WriteLine($"The number was: {randomNumber}");
        break;
    }
    Console.Write($"You have {allowedGuesses - numGuesses} tries left. Enter another number: ");
}