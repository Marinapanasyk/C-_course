// Задача 3: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
void ThirdNumber (int n)
{
    if (n > -100 && n < 100){
        Console.WriteLine("There is no third digit");
        return;
    }
    while(n > 1000 || n < -1000){
        n = n / 10;
    }
    Console.WriteLine(n % 10);
}
Console.Write("Write a number N: ");
int n = int.Parse(Console.ReadLine());

ThirdNumber(n);