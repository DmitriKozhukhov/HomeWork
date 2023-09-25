// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArray(int length)
{
    System.Console.WriteLine();
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine()!);
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

int QuantityOfPositive(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item > 0)
            count++;
    }
    return count;
}

System.Console.WriteLine("Введите количество чисел");
int[] massive = CreateArray(Convert.ToInt32(Console.ReadLine()!));
PrintArray(massive);
System.Console.WriteLine($" -> {QuantityOfPositive(massive)}");
