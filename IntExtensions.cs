using System;

public static class IntExtensions
{
    public static event EventHandler<int> NumberChecked;

    public static bool IsOdd(this int number)
    {
        bool isOdd = number % 2 != 0;
        NumberChecked?.Invoke(null, number);  
        return isOdd;
    }
}
