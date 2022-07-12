
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 2. Напишите программу, которая выводит случайное число
//    из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.WriteLine("Введите Number: ");
int Method1(int Number)
{
   return Number % 100 / 10;
}
int Number = int.Parse(Console.ReadLine());
Console.WriteLine(Method1(Number));
