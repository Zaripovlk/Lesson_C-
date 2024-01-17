/*Задайте массив из N случайных целых чисел (N вводится с 
клавиатуры).
Найдите количество чисел, которые оканчиваются на 1 и 
делятся нацело на 7.
*/
void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"{arr[i]} ");
    }
    Console.WriteLine(); //разделение строкой
}
int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);
    return arr;
}
int InRange(int[] arr)
{
    int n = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 7 == 0 && arr[i] % 10 == 1)
        {
            n++;
        }
    }
    return n;
}


int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);


int[] mass = MassNums(num, start, stop);
int result = InRange(mass);
Print(mass);
Console.WriteLine(result);

