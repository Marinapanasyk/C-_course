// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
void Method1(int a)
{
    int Sum = 0;

    while (a > 0)
    {
        Sum = Sum + a % 10;
        a = a / 10;
    }

    Console.WriteLine(Sum);
}
Method1(456);
