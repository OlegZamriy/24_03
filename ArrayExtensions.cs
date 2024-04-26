using System;
using System.Linq;

public static class ArrayExtensions
{
    public static int[] FilterArray(this int[] inputArray, Func<int, bool> predicate)
    {
        if (inputArray == null || predicate == null)
        {
            throw new ArgumentNullException();
        }

        return inputArray.Where(predicate).ToArray();
    }
}

