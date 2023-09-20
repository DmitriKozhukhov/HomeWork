// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArray(double minVal, double maxVal, int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble() * (maxVal - minVal) + minVal;
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            System.Console.Write($"{array[i]:f2}" + "]");
        else
            System.Console.Write($"{array[i]:f2}" + ", ");
    }
}

double FindMaximum(double[] array)
{
    double maximum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maximum)
            maximum = array[i];
    }
    return maximum;
}

double FindMinimum(double[] array)
{
    double minimum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minimum)
            minimum = array[i];
    }
    return minimum;
}

System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US"); // для того, чтобы целая и дробная часть  
                                                                                                      // вещественного числа разлелялись точкой, а не запятой
System.Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine()!);
System.Console.WriteLine("Введите нижнюю границу диапазона чисел в массиве");
int minValue = Convert.ToInt32(Console.ReadLine()!);
System.Console.WriteLine("Введите верхнюю границу диапазона чисел в массиве");
int maxValue = Convert.ToInt32(Console.ReadLine()!);
if (maxValue > minValue)
{
    double[] massive = CreateArray(minValue, maxValue, length);
    PrintArray(massive);
    System.Console.WriteLine($" -> {FindMaximum(massive):f2} - {FindMinimum(massive):f2}  = {FindMaximum(massive) - FindMinimum(massive):f2} ");
}
else
{
    System.Console.WriteLine($"Ошибка! Значение верхней границы массива должно быть больше значения нижней границы массива");
}

