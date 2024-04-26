using System;
using System.Linq;

public static class StringExtensions
{
    public static int WordCount(this string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

         string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}
