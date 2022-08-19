//Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N.


void ValueSetMinMax(int min, int max)
{
    if (max<min) return;
    ValueSetMinMax(min,max-1);
    if (max % 2 == 0)  
    Console.Write($"{max}, ");}

Console.Write("Введите M: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int max = int.Parse(Console.ReadLine());
ValueSetMinMax(min,max);
