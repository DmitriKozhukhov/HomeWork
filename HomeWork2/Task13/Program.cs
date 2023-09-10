// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// 123456789 -> 3
int number = Convert.ToInt32(Console.ReadLine()!);
if ((number / 100) < 1)
    System.Console.WriteLine("Третьей цифры нет");
else
{
    int remain = number;
    int result = 0;
    while (remain > 100)
    {
        result = remain % 10;
        remain = remain / 10;
    }
    System.Console.WriteLine(result);
}
