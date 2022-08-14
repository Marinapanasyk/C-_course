// 1. Пользователь вводит с клавиатуры M чисел. 
//    Посчитайте, сколько чисел больше 0 ввёл пользователь. 

Console.Write("Сколько чисел хотели бы ввести?: ");
int a = int.Parse(Console.ReadLine());
 
int Check(int num)

{
    int count = 0;
    
    for (int i = 1; i <= num; i++)
    {
        Console.Write($" {i}: ");
        int a = int.Parse(Console.ReadLine());
        if (a > 0) count++;
    }
    return count;
}

Console.WriteLine($"Количество чисел больше нуля: {Check(a)}");