/*Напишите программу, которая перевернёт одномерный массив 
(первый элемент станет последним, второй – предпоследним и т.д.)
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите количество чисел в массиве: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        int[] arr = GenerateRandomArray(n, 1, 9);
        Console.WriteLine("исходный массив : ");
        Print(arr);
        

        for(int i = 0; i < n / 2; i++){
            int min_ind = arr[i];
            arr[i] = arr [n - i - 1];
            arr [n - i - 1] = min_ind;
        }
        Console.WriteLine("преобразованный массив :");
        Print(arr);
        

           
    }
    static void Print(int[] arr) { 
            foreach (int number in arr)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
    static int[] GenerateRandomArray(int n, int min_v, int max_v){
        int[] arr = new int[n];
        Random rand = new Random();

        for( int i = 0; i < n; i++){
            arr[i] = rand.Next(min_v, max_v + 1); 
        }
        return arr;
    }

    
    
}


/*// 3. Напишите программу, которая перевернёт
//    одномерный массив (первый элемент станет
//    последним, второй – предпоследним и т.д.)

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);

    return arr;
}

void RevMas(int[] arr_1)
{
    int size = arr_1.Length;

    for (int i = 0; i < size / 2; i++)
        (arr_1[i], arr_1[size - i - 1]) = (arr_1[size - i - 1], arr_1[i]);
}



int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
RevMas(mass);
Print(mass);