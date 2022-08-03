//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
void Method2(int N)
{
    Console.WriteLine(N);
    Console.Write(N / 100);
    Console.Write(N % 10);
};

int a = new Random().Next(101, 999);
Method2(a);