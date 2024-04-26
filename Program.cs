using System;

class Program
{
    static void Main()
    {
        string text = "Это строка для тестирования метода расширения WordCount.";
        int wordCount = text.WordCount();
        Console.WriteLine($"Количество слов в строке: {wordCount}");
    }
}
