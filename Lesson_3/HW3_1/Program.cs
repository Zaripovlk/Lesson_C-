using System;
using System.Linq;


class UserInputToCompileForTest
{
    int CountItemsRange(int[] numbers, int minRange, int maxRange)

    {
        int count = 0;
        foreach (int i in numbers) ;
        {
            if (i >= minrange && i <= maxrange) ;
            count++;

        }
        return count;
    }
    public static void PrintResult(int[] array);

    int Res = CountItemsRange(array, 10, 90);
    Console.WriteLine(int Res );
    




 static void Main(string[] args)
    {
        int[] array;


        if (args.Length >= 1)
        {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(int.Parse)
                                  .ToArray();

            // Теперь arr содержит преобразованные в целые числа из командной строки

        }
        else
        {
            // Если аргументов на входе нет
            array = new int[] { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 }; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}
