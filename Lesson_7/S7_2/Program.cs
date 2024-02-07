/* Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от 1 до N. */

class Program
{

    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Введите число: ");
        int N = Convert.ToInt32(Console.ReadLine());
        Interval(N);
    }
    static void Interval(int N)
    {
        if (N == 0)
        return;
        Interval(N-1);
        Console.Write(N + "\t");
    }
}