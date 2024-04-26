using System;

public static class StringExtensions
{
    public static event EventHandler<int> ConsonantCounted;

    public static int CountConsonants(this string input)
    {
        int consonantCount = 0;
        foreach (char c in input.ToLower())
        {
            if ("bcdfghjklmnpqrstvwxyz".Contains(c))
            {
                consonantCount++;
            }
        }

        ConsonantCounted?.Invoke(null, consonantCount);  
        return consonantCount;
    }
}
