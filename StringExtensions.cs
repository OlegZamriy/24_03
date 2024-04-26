using System;

public static class StringExtensions
{
    public static event EventHandler<int> SentenceCounted;

    public static int CountSentences(this string input)
    {
        int sentenceCount = 0;
        foreach (char c in input)
        {
            if (c == '.' || c == '?' || c == '!')
            {
                sentenceCount++;
            }
        }

        SentenceCounted?.Invoke(null, sentenceCount);  
        return sentenceCount;
    }
}
