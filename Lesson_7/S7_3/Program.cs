/* /* Считать строку с консоли, содержащую латинские буквы. 
Вывести на экран согласные буквы этой строки.


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        Console.WriteLine("Согласные буквы строки:");
        PrintConsonants(input);

        Console.ReadLine();
    }

    static void PrintConsonants(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return;

        char firstChar = input[0];
        if (IsConsonant(firstChar))
            Console.Write(firstChar);

        PrintConsonants(input.Substring(1));
    }

    static bool IsConsonant(char c)
    {
        return !IsVowel(c) && char.IsLetter(c);
    }

    static bool IsVowel(char c)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        return Array.IndexOf(vowels, c) >= 0;
    }
} */
Console.Clear();
void str(string result, int index = 0)
{
    if (result.Length == index)
        return;
    string vowels = "bcdfghjklmnpqrstvwxz";

    if (vowels.Contains(char.ToLower(result[index])))
    {
        Console.Write(result[index]);
    }
    str(result, index + 1);
}
str("Hello world");