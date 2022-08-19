//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
void GapNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}

Console.Write("Введите M: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int numberN = int.Parse(Console.ReadLine());
GapNumberSum(numberM, numberN, 0);