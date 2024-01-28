/*Задайте двумерный массив. Найдите элементы, у которых оба 
индекса чётные, и замените эти элементы на их квадраты.
*/
//Задача 1
// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter quantity: ");
        int num_1 = Convert.ToInt32(Console.ReadLine());
        int num_2 = Convert.ToInt32(Console.ReadLine());
         

        int[,] arr = GenerateRandomNumbers(num_1, num_2, 1, 10);
        Print(arr);
        Console.WriteLine();
        int[,] new_arr = replacement_of_elements(arr, num_1, num_2);
        Print(new_arr);
        Console.WriteLine();

    }
    static void Print(int[,] arr) { 
        int rows = arr.GetLength(0);
        int columns = arr.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    static int[,] GenerateRandomNumbers(int num_1,  int num_2, int min_v, int max_v){
        int[,] arr = new int[num_1, num_2];
        Random rand = new Random();

        for(int i = 0; i < num_1; i++){
            for(int j = 0; j < num_2; j++){
                arr[i,j] = rand.Next(min_v, max_v + 1);
            }
        }
        return arr;
    }
    static int[,] replacement_of_elements(int[,] arr, int num_1,  int num_2){
        for(int i = 0; i < num_1; i += 2){
            for(int j = 0; j < num_2; j += 2){
               
                arr[i, j] =arr[i, j] * arr[i, j];
                
            }
        }
        return arr;
    }

}