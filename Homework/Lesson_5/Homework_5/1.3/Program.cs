// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Double[] RandomArrayOne(int size)

{
    double[] RandomArray = new double[size];
    for (int i = 0; i < size; i++)
        RandomArray[i] = Math.Round(new Random().NextDouble() * 10, 2);
    return RandomArray;
}
void PrintArray(double[] Array1)
{
    for (int i = 0; i < Array1.Length; i++)
    {
        Console.Write($"{Array1[i]} ");
    }
    Console.WriteLine();
}

void Result(double[] Array2)
{
    double min = Array2[0];
    double max = Array2[0];
    {
        for (int i = 0; i < Array2.Length; i++)
        {
            if (Array2[i] < min)
                min = Array2[i];

            else if (Array2[i] > max)
                max = Array2[i];
        }
        Console.WriteLine($"min= {min}");
        Console.WriteLine($"max= {max}");
        Console.WriteLine($"Result= {max - min}");
    }
}
double[] myArray = new double[1];
myArray = RandomArrayOne(5);
PrintArray(myArray);
Result(myArray);