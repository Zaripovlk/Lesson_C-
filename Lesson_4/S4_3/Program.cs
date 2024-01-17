/*Заполните массив на N (вводится с консоли, не более 8) 
случайных целых чисел от 0 до 9. 
Сформируйте целое число, которое будет состоять из цифр из 
массива. Старший разряд числа находится на 0-м индексе, 
младший – на последнем. */
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

    long CountNum(int[] arr)
{
    string word = "";
    foreach (int number in arr)
    {
        word +=number;
    }
return long.Parse(word);
}
int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);


int[] mass = MassNums(num, start, stop);
long result = CountNum(mass);
Print(mass);
Console.WriteLine(result);
