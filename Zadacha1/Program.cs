﻿Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if (a == b*b)
    {
Console.Write("Первое число является квадратом второго");
    }
    else
    {
        if (b == a*a)
        {
            Console.Write("Второе число является квадратом первого ");
        }
    }
 Console.Write("Ни одно из чисел не является квадратом другого");   