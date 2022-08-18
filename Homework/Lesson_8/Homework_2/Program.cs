//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
int[] Summa (int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    int [] arrSum = new int [row];

    for (int i=0; i< row; i++)
    {
        int sum = 0;
        for (int j=0; j< column; j++)
        {
            sum = sum + array[i, j];
            arrSum[i] = sum;
        }
    }
    return arrSum ;
}


void Minstring (int[] arr)
{
    int posMin = 0;
    for (int i=0; i< arr.Length; i++)
    {
        if (arr[i] < arr[posMin])
            posMin = i;
    }
    Console.WriteLine ($" Строка с наименьшей суммой {posMin +1} ");
}


void ShowArray(int[] coll)
{
    for (int ind = 0; ind < coll.Length; ind++)
    {
        Console.Write ($"{coll[ind]} ");
    }
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MussNums(row, column, 1, 11);
Print(arr_1);

Console.WriteLine();
int[] arr2 = Summa (arr_1);

ShowArray (arr2);
Console.WriteLine();
Minstring (arr2);