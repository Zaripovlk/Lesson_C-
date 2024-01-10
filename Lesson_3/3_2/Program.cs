/*int N = 10;
int [] arr = new int[N];
int i = 0;

while (i < arr.Length)
{
    arr[i] = i + 1;
    //Console.Write(arr[i]);
    //Console.Write(' ');
    Console.Write($"{arr[i]} ");
    i = i + 1 ;


}
*/
int n;
Console.WriteLine("Введите число элементов массива");
n = Convert.ToInt16(Console.ReadLine());
// Объявим одномерный массив Data с n-элементами 
double[] arr = new double[n];
int i = 0;
while (i < n)
{
    Console.WriteLine("Введите элемент массива");
    /* Вводим элементы массива с клавиатуры 
     * и заполняем ими массив */
    arr[i] = double.Parse(Console.ReadLine());
    Console.WriteLine();
    i++;
}
// Вывод содержимого массива
for (i = 0; i < arr.Length; i++)
    Console.WriteLine("Элемент[" + i + "]: " + arr[i]);

double max = arr[0];
for (int j = 0; j < arr.Length; j++)
{
    if (arr[j] > max)
    {
        max = arr[j];
    }

}
Console.WriteLine("Максимальное число массива: " + max + " ");
