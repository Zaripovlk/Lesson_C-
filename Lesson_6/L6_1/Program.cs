
 int Fact(int n)
{
if (n == 0)
{
Console.WriteLine($"Stop requrson:n={n}");
return 1;
}
Console.WriteLine(n);
int fact = Fact(n - 1);
Console.WriteLine($"Возврат:n={n-1}, fact={fact}");
return n * fact;

}

Console.Write(Fact(5));