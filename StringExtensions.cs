using System;

public static class StringExtensions
{
    public static int LengthOfLastWord(this string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        if (words.Length == 0)
        {
            return 0;
        }

        string lastWord = words[words.Length - 1];
        return lastWord.Length;
    }
}
