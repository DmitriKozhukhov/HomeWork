// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
int number = Convert.ToInt32(Console.ReadLine()!);
int remain = number % 2;
if (remain == 0)
    System.Console.WriteLine($"Число {number} четное");
else
    System.Console.WriteLine($"Число {number} нечетное");