/*Задайте произвольную строку. Выясните, является ли она палиндромом.*/
Console.Clear();

bool Polin(string word)
{
    int size = word.Length;
    for (int i = 0; i < size; i++)
    {
        if (word[i] ! == word[size - 1 - i])
            return false;
    }
    return true;
}

Console.Write("Введите текст: ");
string text = Console.ReadLine()!;

bool result = Polin(text);
Console.WriteLine($"Строка полиндром - {result}");
