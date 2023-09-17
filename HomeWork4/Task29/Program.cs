// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
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
    for (int i = 0; i < array.Length; i++)
    {
        if  (i == array.Length - 1)
           System.Console.Write(array[i] + " ");
        else
            System.Console.Write(array[i] + ", ");
    }
    System.Console.WriteLine();
}
int length = 8;
System.Console.WriteLine("Введите нижнюю границу диапазона чисел");
int minVal = Convert.ToInt32(Console.ReadLine()!);
System.Console.WriteLine("Введите верхнюю границу диапазона чисел");
int maxVal = Convert.ToInt32(Console.ReadLine()!);
PrintArray(CreateArray(minVal, maxVal, length));
