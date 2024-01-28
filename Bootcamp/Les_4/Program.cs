﻿// Сортировка Выбором О(n^2)

/*
[45, 23, -10, 5, 3, 9, 1]
min = -10;
[-10,23,45,5,3,9,1]
min = 1;
[-10,1,45,5,3,9,23]
min = 3
[-10,1,3,45,5,9,23]
min=5
[-10,1,3,5,9,45,23]
min = 23
[-10,1,3,5,9,23,45]
*/
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    
        array[i] = new Random().Next(-20, 20); // от -20 до 20 рандом
    
}

int[] sortVibor(int[] array)
{
    for (int i = 0; i < array.Length; i++) // лучше всего для счетчика использовать i,j,k,m,n
    {
        int indexMin = i;
        for (int j = i; j < array.Length; j++)
        {
            if (array[j] < array[indexMin])
                indexMin = j;
        }
        if (array[indexMin] == array[i])
            continue;

        int temp = array[i];
        array[i] = array[indexMin];
        array[indexMin] = temp;

    }
    return array;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Конечный массив: [{string.Join(", ", sortVibor(array))}]");

