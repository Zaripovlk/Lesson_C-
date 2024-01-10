//int N = 10;
int[] arr = { 2, 5, 4, 7, 8, 35, 1, 8, 5, 4 };
int i = 0;

while (i < arr.Length)
{
    if (arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
    i = i + 1;

}

