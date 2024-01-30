int[,] CreatMatrix(int rowcount, int columsCount)
{
    int[,] matrix = new int[rowcount, columsCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = rnd.Next(1, 1000);

        }
    }
    return matrix;
}

int[,] matrix CreatMatrix(3,4)

foreach (int e in matrix)
{
   if (IsIntresting(e) == true)
   {
    Console.WriteLine(e);
   } 
}

bool IsIntresting(int value)
{
    int sumOfGigits = GetSumOfDigits(value);
    /*if (sumOfGigits % 2 == 0) первый способ.
    {
        return true;
    }
    else
    {
        return false;
    }*/

    if (sumOfGigits % 2 == 0) первый способ.
    {
        return true;
    }
    return false;
}
int GetSumOfDigits(int value)
{
    int Sum = 0;
    while (value > 0)
    {
        Sum = Sum + value % 10;
        value = value / 10;
    }
    return Sum;
}
