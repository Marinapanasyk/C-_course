//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j],1} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}
int[,] Sort(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int posMin = 0;
            for (int f = 0; f < arr.GetLength(1) - j; f++)
            {
                if (arr[i, f] < arr[i, posMin])
                    posMin = f;
            }

            (arr[i, posMin], arr[i, arr.GetLength(1) - 1 - j]) = (arr[i, arr.GetLength(1) - 1 - j], arr[i, posMin]);
        }
    }
    return arr;
}
Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(row, column, 1, 11);
Print(arr_1);
Sort(arr_1);
Console.WriteLine();
int[,] arr2 = Sort(arr_1);
Print(arr2);






