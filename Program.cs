using System;

System.Console.Write("Guess a secret number");

string number = System.Console.ReadLine();

if (string.IsNullOrWhiteSpace(number))
{
    System.Console.WriteLine("Fine, don't guess'!");
}
else
{
    System.Console.WriteLine($"Your guess is {number}!");
}
