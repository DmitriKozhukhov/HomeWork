// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetArray(int rows, int cols, int minValue = 1, int maxValue = 5)
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

bool CheckMatrixAbleToMultiply(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
        return false;

    return true;
}

int[,] MultiplyMatrixs(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    return matrixC;
}

int[,] matrixA = GetArray(3, 5);
int[,] matrixB = GetArray(5, 4);
/*
Для проверки матриц из условия задачи
int[,] matrixA = { 
    {2, 4},
    {3, 2}
};

int[,] matrixB = { 
    {3, 4},
    {3, 3}
};
*/

PrintArray(matrixA);
PrintArray(matrixB);
if (!CheckMatrixAbleToMultiply(matrixA, matrixB))
    System.Console.WriteLine("Ошибка! Число столбцов первой матрицы должно быть равно числу строк второй матрицы");
else
{
    int[,] matrixC = MultiplyMatrixs(matrixA, matrixB);
    PrintArray(matrixC);
}

