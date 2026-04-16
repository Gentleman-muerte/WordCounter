using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Indtast din fødselsdato (yyyy-mm-dd):");

        string input = Console.ReadLine();
        DateOnly fødselsdato = DateOnly.Parse(input);

        PensionService service = new PensionService();
        Result result = service.Beregn(fødselsdato);

        Console.WriteLine($"Din alder er: {result.Alder}");
        Console.WriteLine($"År til pension: {result.ÅrTilPension}");

        if (result.VisAdvarsel)
        {
            Console.WriteLine("Du skal tjekke din pension opsparing!");
        }
    }
}