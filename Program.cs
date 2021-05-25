using System;

System.Console.Write("Guess a secret number");

string number = System.Console.ReadLine();
string secretNumber = "42";

if (number == secretNumber)
{
    System.Console.WriteLine("That's it! Congrats!");
}
else
{
    System.Console.WriteLine($"Your guess of {number} is incorrect. Guess again.");
}
