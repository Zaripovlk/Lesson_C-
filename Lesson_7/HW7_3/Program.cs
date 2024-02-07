/*  Задайте произвольный массив. Выведете 
его элементы, начиная с конца. Использовать 
рекурсию, не использовать циклы.
 */
using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        Console.Write("Введите размер массива N: ");
        int N = int.Parse(Console.ReadLine()!);

        int[] arr = new int[N];

        // Заполняем массив случайными числами
        Random rnd = new Random();
        for (int i = 0; i < N; i++)
        {
            arr[i] = rnd.Next(100);
        }
        // Выводим массив элементов, начиная с конца
        Console.WriteLine("Начальный массив");
        PrintArray(arr);
        Console.WriteLine("Преобразованный массив");
        PrintArrayReverse(arr, N - 1);
    }
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write( num + " ");
        }
        Console.WriteLine();
    }
    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.Write(arr[index] + " ");
            PrintArrayReverse(arr, index - 1);
        }
    }


}