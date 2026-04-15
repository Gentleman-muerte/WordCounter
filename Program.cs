using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(ProcessValue(25));
        Console.WriteLine(ProcessValue("Hej verden"));
        Console.WriteLine(ProcessValue(3.14));
    }

    public static dynamic ProcessValue(dynamic input)
    {
        if (input is int)
        {
            return 100 + input;
        }

        if (input is string)
        {
            return "Følgende tekst modtaget: " + input;
        }

        return false;
    }
}