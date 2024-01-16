/*Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве. Программа 
должна выдать ответ: Да/Нет.
*/
// 1 Способ:
/*Console.WriteLine("Введите значение: ");
int a = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[] {12, 22, 5, 7 , 15};
int b  = 0;
for (int i = 0; i < arr.Length; i++)
{
    if ( a  == arr[i]) {
        b = 1;

    }
}
      if (b==1) 
      Console.WriteLine("да");
    
    else Console.WriteLine("Нет");
*/
// 2 Способ:
Console.WriteLine("Введите значение: ");
int a = int.Parse(Console.ReadLine()!);
int [] arr = new int[] {1,2,3,4,5};
int i = 0;
bool found = false ;
while (i<arr.Length)
{ if (a == arr[i]) {
found = true;
break; }
i = i+1;

}
if (found) 
{
    Console.WriteLine("да");
}
else Console.WriteLine("Нет");