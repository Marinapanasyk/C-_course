// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Method4(int N)

{
   if ( N > 7) 
   Console.WriteLine("Ошибка при вводе");
   else {if (N < 6)
   Console.WriteLine("Рабочий день");

    else
   Console.WriteLine("Выходной");
}};

Console.WriteLine("Введите номер дня недели: ");
int a = int.Parse(Console.ReadLine());

Method4(a);

