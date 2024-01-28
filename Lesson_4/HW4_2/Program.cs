/*Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
*/
class Program
{
    static void Main()
    {

        Console.WriteLine("введите количество чисел в массиве: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Print(" ");
        int[] arr = GenerateRandomArray(n, 100, 500);
        foreach (int num in arr)
        {
            Print("Элемент : " + num.ToString());
        }
        int count = EvenElements(arr);
        {
            Print("Количество четных элементов : " + count.ToString());
        }
    }

    public static void Print(string res)
    {
        Console.WriteLine(res);
    }

    static int[] GenerateRandomArray(int n, int min_val, int max_val)
    {
        int[] arr = new int[n];
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            arr[i] = random.Next(min_val, max_val + 1);
        }
        return arr;
    }

    static int EvenElements(int[] arr)
    {
        int count = 0;
        foreach (int num in arr)
        {
            if (num % 2== 0 )
            {
                count++;
            }

        }
        return count;
        {

        }
    }
}

//// 1. Напишите программу, которая бесконечно
//    запрашивает целые числа с консоли. Программа
//    завершается при вводе символа ‘q’ или при вводе
//    числа, сумма цифр которого четная.

void InfEnter()
{
    string word;

    while (true)
    {
        Console.Write("Output any number: ");
        word = Console.ReadLine()!;

        if (word != "q")
        {
            int count = 0;
            int number = int.Parse(word);            
            for (; number > 0; number /= 10)
                count += number % 10;

            if (count % 2 == 0)
            {
                Console.WriteLine("Game is over! Number is even");
                return;
            }
        }
        else
            return;
    }
}
/*//// 2. Задайте массив заполненный случайными
//    трёхзначными числами. Напишите программу,
//    которая покажет количество чётных чисел в
//    массиве.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)    
        Console.Write($"{arr[i]} ");
    
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)    
        arr[i] = new Random().Next(100, 1000);
    
    return arr;
}

int EvenNum(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)        
            count += 1;                
    }
    return count;
}

int num = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
Console.WriteLine(EvenNum(mass));