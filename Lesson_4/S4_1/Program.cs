/*Задайте одномерный массив, заполненный случайными 
числами. Определите количество простых чисел в этом 
массиве.
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
int CountSimpleNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (FindSimpleNum(arr[i]))
        {
            count++;

        }
    }
    return count;
}
bool FindSimpleNum(int NN)
{
    if (NN < 2)
        return false;

    for (int i = 2; i < NN; i++)
    {
        if (NN % i == 0)
            return false;
    }
    return true;
}
int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);


int[] mass = MassNums(num, start, stop);
Print(mass);
int MMM = CountSimpleNum(mass);
Console.WriteLine(MMM);