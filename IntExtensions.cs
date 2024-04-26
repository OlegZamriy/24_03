using System;

public static class IntExtensions
{
    public static event EventHandler<int> NumberChecked;

    public static bool IsEven(this int number)
    {
        bool isEven = number % 2 == 0;
        NumberChecked?.Invoke(null, number);  
        return isEven;
    }
}
