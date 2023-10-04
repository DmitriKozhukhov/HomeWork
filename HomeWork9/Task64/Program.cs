﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintEven(int n)
{
    if (n == 1)
    {
        System.Console.Write(n);
        return;
    }
    Console.Write($"{n}, ");
    PrintEven(n - 1);
}
int n = 10;
Console.Write($"N = {n} -> ");
PrintEven(n);