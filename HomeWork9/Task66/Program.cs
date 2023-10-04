// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumOfEvenElements(int m, int n)
{
    if (m == n)
        return m;
    return m + SumOfEvenElements(m + 1, n);
}

int m = 4;
int n = 8;
if (0 < m && m <= n)
    Console.Write($"M = {m}; N = {n} -> {SumOfEvenElements(m, n)}");
else
    Console.WriteLine("Ошибка! N должен быть больше или равен M. M и N должны быть больше 0.");