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

        // Call method from the OTHER class
        int result = WordCounter.CountWord(word, text);

        Console.WriteLine("The word '" + word + "' appears " + result + " times.");
    }
}