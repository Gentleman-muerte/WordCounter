using System;

namespace wordcounter_proppter
{
    internal class WordCounter
    {
        public static Result<int> CountWord(string word, string text)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return Result<int>.Failure("Search word cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(text))
            {
                return Result<int>.Failure("Text cannot be empty.");
            }

            int count = 0;

            word = word.ToLower();
            string[] words = text.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string w in words)
            {
                if (w == word)
                {
                    count++;
                }
            }

            return Result<int>.Success(count);
        }
    }
}