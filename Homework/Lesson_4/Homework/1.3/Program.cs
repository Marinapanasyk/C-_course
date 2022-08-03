// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int[] Array(int num)
{
    int[] array1 = new int[num];
    for(int i=0; i < num; i++)
        array1[i]=new Random().Next(0, 10);
    return array1;
}

void Arrayprint(int[] array2)
{
    for(int i=0; i < array2.Length; i++)
        Console.WriteLine($"{array2[i]} ");
}
Arrayprint(Array(8));
