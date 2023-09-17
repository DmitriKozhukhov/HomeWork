// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int SumOfDigits(int number)
{
    int result = 0;
    while (Math.Abs(number) > 0)
    {
        result += Math.Abs(number) % 10;
        number = Math.Abs(number) / 10;
    }
    return result;
}

int number = Convert.ToInt32(Console.ReadLine()!);
System.Console.WriteLine(SumOfDigits(number));

