using System;

Console.WriteLine("Indtast din fødselsdato (yyyy-mm-dd):");

string input = Console.ReadLine();

if (!DateOnly.TryParse(input, out DateOnly fødselsdato))
{
    Console.WriteLine("Ugyldig dato!");
    return;
}

const int pensionsAlder = 67;

var calculator = new PensionCalculator();
var result = calculator.Calculate(fødselsdato, pensionsAlder, (alder, årTilPension, visAdvarsel) => new
{
    Alder = alder,
    ÅrTilPension = årTilPension,
    VisAdvarsel = visAdvarsel
});

Console.WriteLine($"Din alder er: {result.Alder}");
Console.WriteLine($"År til pension: {result.ÅrTilPension}");

if (result.VisAdvarsel)
{
    Console.WriteLine("Du skal tjekke din pension opsparing!");
}
