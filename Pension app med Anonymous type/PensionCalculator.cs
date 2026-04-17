using System;

public class PensionCalculator
{
    public T Calculate<T>(DateOnly fødselsdato, int pensionsAlder, Func<int, int, bool, T> projector)
    {
        DateOnly iDag = DateOnly.FromDateTime(DateTime.Now);
        int alder = iDag.Year - fødselsdato.Year;
        if (iDag < fødselsdato.AddYears(alder))
        {
            alder--;
        }

        int årTilPension = pensionsAlder - alder;
        bool visAdvarsel = årTilPension < 5;

        return projector(alder, årTilPension, visAdvarsel);
    }
}
