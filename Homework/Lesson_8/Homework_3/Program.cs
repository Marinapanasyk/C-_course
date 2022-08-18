// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
void Print1(int[,] arr2)
{
    int row_size = arr2.GetLength(0);
    int column_size = arr2.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr2[i, j],1} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int [,] MussNums (int row, int column, int from, int to)
{
    int [,] arr = new int[row, column];

    for (int i=0; i< row; i++)
    {
        for (int j=0; j< column; j++)
        {
            arr[i, j] = new Random().Next (from,to);
        }
    }
    return arr; 
}
int [,] MussNums1 (int row, int column, int from, int to)
{
    int [,] arr2 = new int[row, column];

    for (int i=0; i< row; i++)
    {
        for (int j=0; j< column; j++)
        {
            arr2[i, j] = new Random().Next (from,to);
        }
    }
    return arr2;
}
int[,] multiplication (int[,] arr,  int[,] arr2)
{int[,] mult = new int[arr.GetLength(0), arr2.GetLength(1)];
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i=0; i< row; i++)
    {
        for (int j=0; j< column; j++)
        {
            mult [i,j] = (arr2[i,j] * arr[i,j]);
        }
    }
    return mult;
}}
void Print3(int[,] mult)
{
    int row_size = mult.GetLength(0);
    int column_size = mult.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {mult[i, j],1} ");
        }
        Console.WriteLine();}
         Console.WriteLine();
    }



Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MussNums(row, column, 1, 11);
int[,] arr_2 = MussNums1(row, column, 1, 11);
Print(arr_1);
Print1(arr_2);
int[,] mult1 = multiplication (arr_1, arr_2);
Console.WriteLine();
Print3(mult1);