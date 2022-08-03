// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Searching (int N)
{
    int b = 1;
    while (b <= N)
    {
        Console.WriteLine(Math.Pow(b, 3));
        b = b+1;
    }
}
Searching(3);
