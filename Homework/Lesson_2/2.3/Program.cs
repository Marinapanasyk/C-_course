﻿// Напишите программу, которая будет принимать на вход два числа и выводить,
//    является ли второе число кратным первому. Если число 2 не кратно числу 1, то
//    программа выводит остаток от деление.
void Method1 (int a, int b)
{
    if (a%b == 0)
    Console.WriteLine ("кратно");
    else
    {
        Console.WriteLine ($"не кратно {a%b}");
    }
}

Method1 (16,4);
