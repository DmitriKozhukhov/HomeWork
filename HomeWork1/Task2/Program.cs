// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
int number1 = Convert.ToInt32(Console.ReadLine()!);
int number2 = Convert.ToInt32(Console.ReadLine()!);
if (number1 > number2)
    System.Console.WriteLine($"{number1} больше, чем {number2}");
else if (number1 < number2)
    System.Console.WriteLine($"{number1} меньше, чем {number2}");
else
    System.Console.WriteLine($"{number1} равно {number2}");

