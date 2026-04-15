using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a value: ");
        string input = Console.ReadLine();

        dynamic result = ProcessValue(input);

        Console.WriteLine(result);
    }

    public static dynamic ProcessValue(dynamic input)
    {
        
        if (input == null || string.IsNullOrWhiteSpace(input.ToString()))
        {
            return false; 
        }

        
        if (int.TryParse(input.ToString(), out int number))
        {
            return 100 + number;
        }

        
        if (input is string)
        {
            return "Følgende tekst modtaget: " + input;
        }

        
        return false;
    }
}