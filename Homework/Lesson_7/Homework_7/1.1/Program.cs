// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
    double[,] fillArray()
{
   Console.WriteLine("Введите количество строк m=");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n=");
int n = int.Parse(Console.ReadLine());
double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * (100 + 150) - 100, 2); ;
        }
    }
    return array;
}

void printArray(double[,] array)
{
    for (int i = 0; i <  array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} "); 
        }
        Console.WriteLine();
    }
}

printArray(fillArray());
