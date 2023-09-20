//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
//  [345, 897, 568, 234] -> 2
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

int CountOfEvenNumbers(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0)
            count++;
    }
    return count;
}
int minValue = 100;
int maxValue = 999;
System.Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine()!);
int[] massive = CreateArray(minValue, maxValue, length);
PrintArray(massive);
System.Console.WriteLine($" -> {CountOfEvenNumbers(massive)}");


