// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
int dayOfWeek = Convert.ToInt32(Console.ReadLine()!);
if (dayOfWeek > 0 && dayOfWeek <= 5)
   System.Console.WriteLine("Нет");
else if (dayOfWeek == 6 | dayOfWeek == 7) 
    System.Console.WriteLine("Да");
else 
    System.Console.WriteLine("Ошибка! Введите число от 1 до 7");