using System;

Console.WriteLine("Indtast din fødselsdato (yyyy-mm-dd):");

string input = Console.ReadLine();

if (!DateOnly.TryParse(input, out DateOnly fødselsdato))
{
    Console.WriteLine("Ugyldig dato!");
    return;
}


const int pensionsAlder = 67;


DateOnly iDag = DateOnly.FromDateTime(DateTime.Now);


int alder = iDag.Year - fødselsdato.Year;

if (iDag < fødselsdato.AddYears(alder))
{
    alder--;
}


int årTilPension = pensionsAlder - alder;


var result = new
{
    Alder = alder,
    ÅrTilPension = årTilPension,
    VisAdvarsel = årTilPension < 5
};


Console.WriteLine($"Din alder er: {result.Alder}");
Console.WriteLine($"År til pension: {result.ÅrTilPension}");

if (result.VisAdvarsel)
{
    Console.WriteLine("Du skal tjekke din pension opsparing!");
}