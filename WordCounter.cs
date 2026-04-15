using System;
using System.Collections.Generic;
using System.Text;

namespace wordcounter_proppter
{
    internal class WordCounter
    {
        public static int CountWord(string word, string text)
        {
            int count = 0;

            word = word.ToLower();
            text = text.ToLower();

            int index = 0;

            while ((index = text.IndexOf(word, index)) != -1)
            {
                count++;
                index++;
            }

            return count;
        }
    }
}


