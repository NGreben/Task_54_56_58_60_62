/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] array1 = CreateArray(2, 2, 1, 5);
PrintArray(array1);
Console.WriteLine("*");
int[,] array2 = CreateArray(2, 2, 1, 5);
PrintArray(array2);
Console.WriteLine("=");
PrintArray(MultiplicationMatrix(array1, array2));

int[,] CreateArray(int row, int column, int min, int max)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(min, max);
    return array;
}

void PrintArray(int[,] array, string title = " ")
{
    if (title != " ")
        Console.Write($"{title}\n");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
{
    int[,] multArray = CreateArray(2, 2, 0, 1);

    for (int i = 0; i < array1.GetLength(0); i++)
        for (int j = 0; j < array2.GetLength(1); j++)
            for (int k = 0; k < array1.GetLength(0); k++)
                multArray[i, j] += array1[i, k] * array2[k, j];
    return multArray;
}