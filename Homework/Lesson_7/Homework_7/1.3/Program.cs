
//  Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}
void Average(int[,] array)
{
    double result = 0;
    Console.WriteLine("среднее арифметическое элементов в столбце:");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result += array[i, j];
        }
        Console.Write($"{Math.Round(result / array.GetLength(0), 2)} \t");
        result = 0;
    }

}
Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(row, column, 1, 11);

Print(arr_1);

Console.WriteLine("Введите номер строки элемента :");
int pos1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента :");
int pos2 = int.Parse(Console.ReadLine());

Average(arr_1);
