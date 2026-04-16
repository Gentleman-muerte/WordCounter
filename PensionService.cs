using System;

public class PensionService
{
    public const int PensionsAlder = 67;

    public Result Beregn(DateOnly fødselsdato)
    {
        DateOnly iDag = DateOnly.FromDateTime(DateTime.Now);

        int alder = iDag.Year - fødselsdato.Year;

        
        if (iDag < fødselsdato.AddYears(alder))
        {
            alder--;
        }

        int årTilPension = PensionsAlder - alder;

        return new Result
        {
            Alder = alder,
            ÅrTilPension = årTilPension,
            VisAdvarsel = årTilPension < 5
        };
    }
}