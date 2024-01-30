// 1. Задайте массив символов (тип char []).
//    Создайте строку из символов этого массива.
//    Конструктор строки вида string(char []) не использовать.

char[] muss = { 'a', 'b', 'c', 'd' };
string result = "";
foreach (char i in muss)
{
    result = result + i;
}
Console.WriteLine(result);



// class Program
// {
//     static void Main(string [] args)
//     {
//         Console.Clear();
//         char[] chars = new char[] {'a','b','c','d'};
//         for (int y = 0; y < chars.Length; y++)
//         {
//             Console.Write(chars[y]);
//         }
//         Console.ReadLine();
//     }
// }