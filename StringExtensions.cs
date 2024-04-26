using System;

public static class StringExtensions
{
    public static event EventHandler<int> VowelCounted;

    public static int CountVowels(this string input)
    {
        int vowelCount = 0;
        foreach (char c in input.ToLower())
        {
            if ("aeiou".Contains(c))
            {
                vowelCount++;
            }
        }

        VowelCounted?.Invoke(null, vowelCount);  
        return vowelCount;
    }
}
