using System;

class Program
{
    static void Main()
    {
        IntExtensions.NumberChecked += NumberCheckedHandler;

        int numberToCheck = 12;

        if (numberToCheck.IsEven())
        {
            Console.WriteLine($"{numberToCheck} є парним числом.");
        }
        else
        {
            Console.WriteLine($"{numberToCheck} є непарним числом.");
        }
    }

    static void NumberCheckedHandler(object sender, int number)
    {
        Console.WriteLine($"Подія: перевірка числа {number} на парність.");
    }
}
