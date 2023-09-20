// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int minVal, int maxVal, int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            System.Console.Write(array[i] + "]");
        else
            System.Console.Write(array[i] + ", ");
    }
}

int SumOfOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}


System.Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine()!);
System.Console.WriteLine("Введите нижнюю границу диапазона чисел в массиве");
int minValue = Convert.ToInt32(Console.ReadLine()!);
System.Console.WriteLine("Введите верхнюю границу диапазона чисел в массиве");
int maxValue = Convert.ToInt32(Console.ReadLine()!);
if (maxValue > minValue)
{
    int[] massive = CreateArray(minValue, maxValue, length);
    PrintArray(massive);
    System.Console.WriteLine($" -> {SumOfOddPositions(massive)}");
}
else
{
    System.Console.WriteLine($"Ошибка! Значение верхней границы массива должно быть, больше значения нижней границы массива");
}
