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


