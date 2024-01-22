Console.Clear();
int[] array = new int[5];
int conv = 0;
for (int i = 0; i < 5; i++)

{
    conv = i + 1;
    Console.Write($"Введите число {conv}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Созданный массив: [" + string.Join(",", array) + "]");
Console.WriteLine("Выводим 4 элемент массива: " + array[3]);

// Сложность алгоритма О(1)- это количество действий чтобы узнать результат.