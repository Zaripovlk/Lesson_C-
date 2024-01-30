// 3. Считать строку с консоли, состоящую из латинских
//    букв в нижнем регистре. Выяснить, сколько среди
//    введённых букв гласных.
Console.Clear();

string str = "Hello";
int CharToArr(string word)
{
    string vowels = "aeiou";
    int value = 0;

    for (int i = 0; i < word.Length; i++)
    {
        if (vowels.Contains(word[i]))
            value++;

    }
    return value;
}
Console.WriteLine(CharToArr(str));
