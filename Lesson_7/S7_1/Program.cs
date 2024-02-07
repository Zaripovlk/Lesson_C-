/* 
Напишите программу, которая будет принимать на вход число и 
возвращать сумму его цифр */
Console.Clear();
int sum(int numbers)
{
    if (numbers == 0)
        return 0;
    return sum(numbers / 10) + numbers % 10;
}
Console.WriteLine(sum(123));
