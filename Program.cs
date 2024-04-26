using System;

class Program
{
    static void Main()
    {
        string text = "Це приклад рядка для тестування методу LengthOfLastWord.";
        int lengthOfLastWord = text.LengthOfLastWord();
        Console.WriteLine($"Довжина останнього слова в рядку: {lengthOfLastWord}");
    }
}
