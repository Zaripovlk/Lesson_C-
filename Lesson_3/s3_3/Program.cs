/*Найдите произведения пар чисел в одномерном массиве. Парой 
считаем первый и последний элемент, второй и предпоследний и 
т.д. Результат запишите в новый массив.
*/
// Способ №1
/*
Console.WriteLine("Количество элементов массива: ");
int Count = int.Parse(Console.ReadLine()!);
int[] my_massive = new int[Count];

Random el_mas = new();
Console.WriteLine("МАссив: [ ");
for (int i = 0; i < Count; i++)
{
    my_massive[i] = el_mas.Next(-10, 10);
    Console.WriteLine(my_massive[i] + " ,");
}

Console.WriteLine("]");

int b = 0;
Count = Count - 1;
while ((b != Count) && (b ! < Count))
{
    my_massive[b] = my_massive[b] * my_massive[Count];
    Console.WriteLine(my_massive[b] + ",");
    b++;
    Count--;
    if (b != 0 && b == Count)
        Console.WriteLine($"Эллеменот {my_massive[b]} c индексом {b} не имеет пары");
}
*/
Console.WriteLine("Количество элементов массива: ");
int Count = int.Parse(Console.ReadLine()!);
int[] my_massive = new int[Count];

Random el_mas = new();
Console.WriteLine("МАссив: [ ");
for (int i = 0; i < Count; i++)
{
    my_massive[i] = el_mas.Next(-10, 10);
    Console.WriteLine(my_massive[i] + " ,");
}

Console.WriteLine("]");

int [] res = new int [my_massive.Length/2];
for (int i=0; i < my_massive.Length/2; i++) {
    res[i] = my_massive[i] * my_massive[my_massive.Length - 1 - i];
    Console.WriteLine("Результат :" + res[i]);  
}