using System;

namespace wordcounter_proppter
{
    internal class DynamicHandler
    {
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
}