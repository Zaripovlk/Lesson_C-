/* Задайте строку, содержащую латинские буквы в обоих регистрах. 
Сформируйте строку, в которой все заглавные буквы заменены на строчные.*/
Console.Clear();

string Stroka(string word)
{
    return word.ToLower();
}
Console.WriteLine("Enter some text: ");
string text = Console.ReadLine()!;

string result = Stroka(text);
Console.WriteLine(result);
