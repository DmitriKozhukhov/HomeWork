// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetArray(int rows, int cols, int minValue = 0, int maxValue = 10)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintRowSums(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

int FindRowWithMinSum(int[] array)
{
    int minIndex = 0;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minIndex = i;
        }
    }
    return minIndex + 1; // возвращаем именно номер строки, а не индекс, т.к. так задано в условии задачи
}

int[] CreateArrayOfSums(int[,] array)
{
    int[] rowSums = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSums[i] += array[i, j];
        }
    }
    return rowSums;
}
int[,] massive = GetArray(3, 5);
PrintArray(massive);
int[] rowSums = CreateArrayOfSums(massive);
PrintRowSums(rowSums);
Console.WriteLine();
Console.WriteLine($"{FindRowWithMinSum(rowSums)} строка");