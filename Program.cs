using System;
using wordcounter_proppter;

class Program
{
    static void Main()
    {
        Console.Write("Enter word to search: ");
        string word = Console.ReadLine();

        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        var result = WordCounter.CountWord(word, text);

        if (!result.IsSuccess)
        {
            Console.WriteLine("Error: " + result.Error);
            return;
        }

        Console.WriteLine($"The word appears {result.Value} times.");
    }
}