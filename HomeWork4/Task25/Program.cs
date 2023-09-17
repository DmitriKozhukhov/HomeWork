// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int RaiseToPower(int number, int power)
{
    int result = 1;
    for (int i = 1; i <= power; i++)
    {
        result = result * number;
    }
    return result;
}
int number = Convert.ToInt32(Console.ReadLine()!);
int power = Convert.ToInt32(Console.ReadLine()!);
System.Console.WriteLine(RaiseToPower(number, power));