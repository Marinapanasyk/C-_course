 //Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//указание, что такого элемента нет.
void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j], 1} ");
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

string Position(int [,] arr, int pos1, int pos2)
{  
    if(pos1>arr.GetLength(0) | pos2>arr.GetLength(1))
        return $"Такого элемента нет";
    else
        return $"{arr[pos1-1,pos2-1]}";
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

Console.WriteLine(Position(arr_1, pos1, pos2));

