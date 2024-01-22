/* Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
*/
using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите целое число или 'q' для завершения: ");
            string Input = Console.ReadLine();

            // Проверка на выход по "q"
            if (Input == "q")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            // Проверка на сумму цифр четную
            if (int.TryParse(Input, out int number))
            {
                int sum = sum_numbers(number);
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"Сумма цифр числа {number} четная. Программа завершена.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Введите целое число или 'q' для завершения.");
            }
        }
    }

    static int sum_numbers(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}
