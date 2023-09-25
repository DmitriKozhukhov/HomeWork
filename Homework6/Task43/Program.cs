//  Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
//  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void PrintArray(double[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            System.Console.Write($"{array[i]:f2} ]");
        else
            System.Console.Write($"{array[i]:f2} ; ");
    }
}

double[] InputParameters()
{
    int length = 4;
    double[] array = new double[length];
    System.Console.WriteLine("Введите b1");
    array[0] = Convert.ToDouble(Console.ReadLine()!);
    System.Console.WriteLine("Введите k1");
    array[1] = Convert.ToDouble(Console.ReadLine()!);
    System.Console.WriteLine("Введите b2");
    array[2] = Convert.ToDouble(Console.ReadLine()!);
    System.Console.WriteLine("Введите k2");
    array[3] = Convert.ToDouble(Console.ReadLine()!);
    return array;

}

double[] PointCoordinates(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    double[] coordinates = new double[2];
    coordinates[0] = x;
    coordinates[1] = y;
    return coordinates;

}

double[] massive = InputParameters();
System.Console.Write($" b1 = {massive[0]}, k1 = {massive[1]}, b2 = {massive[2]}, k2 = {massive[3]} -> ");
PrintArray(PointCoordinates(massive[0], massive[1], massive[2], massive[3]));

