// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return AckermannFunction(m - 1, 1);
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}
int m = 3;
int n = 3;
if (0 <= m && 0 <= n)
    Console.Write($"m = {m}; n = {n} -> A(m,n) = {AckermannFunction(m, n)}");
else
    Console.WriteLine("Ошибка! M и N должны быть целыми неотрицательными числами.");

Console.WriteLine();
Console.WriteLine();

for (int ni = 0; ni < 6; ni++)   // Вывод таблички первых значений функции Аккермана, для удобства проверки
{
    for (int mi = 0; mi < 4; mi++)
    {
        Console.Write(AckermannFunction(mi, ni) + "\t");
    }
    Console.WriteLine();
}

