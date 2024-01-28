// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива. 

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

        double[] average_arr = average(arr);
        foreach (double el in average_arr)
        {
            Console.WriteLine("element : " + el);
        }
        

    }
    static void Print(int[,] arr) { 
       
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
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
    static double[] average(int[,] arr){
        double[] av = new double[arr.GetLength(0)] ;
        
        for(int i = 0; i < arr.GetLength(0); i++){
            double sum = 0;
            for(int j = 0; j < arr.GetLength(1); j++){
                sum += arr[i, j]; 
            }
            av[i] = sum / arr.GetLength(1);
        }
        
        return av;
    }
        
    }