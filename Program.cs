using System;

class Program
{
    static void Main()
    {
        IntExtensions.NumberChecked += NumberCheckedHandler;

        int numberToCheck = 13;

        if (numberToCheck.IsOdd())
        {
            Console.WriteLine($"{numberToCheck} є непарним числом.");
        }
        else
        {
            Console.WriteLine($"{numberToCheck} є парним числом.");
        }
    }

    static void NumberCheckedHandler(object sender, int number)
    {
        Console.WriteLine($"Подія: перевірка числа {number} на непарність.");
    }
}
