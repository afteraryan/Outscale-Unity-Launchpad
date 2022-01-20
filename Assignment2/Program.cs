using System;
class StoryColor
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Wellerrman");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("There once was a ship that put to sea \nThe name of the ship was the Billy of Tea");
        Console.ResetColor();
    }
}