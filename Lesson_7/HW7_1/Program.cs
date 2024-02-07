/* Задайте значения M и N. Напишите 
программу, которая выведет все натуральные числа 
в промежутке от M до N. Использовать рекурсию, не 
использовать циклы.
 */
 class Program
{
    static void Main(string[] args)
    {
        // Ввод значений M и N
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());
        
        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        // Вызов рекурсивной функции для вывода чисел
        numbers(M, N);

        Console.ReadLine();
    }

    static void numbers(int M, int N)
    {
        // Базовый случай - если M больше N, то рекурсия заканчивается
        if (M > N)
            return;

        // Выводим число M и вызываем рекурсивно функцию для числа M + 1
        Console.WriteLine(M);
        numbers(M + 1, N);
    }
}