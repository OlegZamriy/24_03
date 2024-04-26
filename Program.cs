using System;

class Program
{
    static void Main()
    {
        StringExtensions.ConsonantCounted += ConsonantCountedHandler;

        string text = "Це є приклад рядка для підрахунку приголосних літер.";

        int consonantCount = text.CountConsonants();
        Console.WriteLine($"Кількість приголосних літер у рядку: {consonantCount}");
    }

    static void ConsonantCountedHandler(object sender, int count)
    {
        Console.WriteLine($"Подія: підрахунок приголосних літер у рядку - {count}");
    }
}
