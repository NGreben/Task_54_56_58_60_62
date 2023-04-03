/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int count = 8;

int[,] array = new int[4, 4];
for (int i = 0; i < 1; i++)
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = j + 1;

for (int i = 1; i < array.GetLength(0); i++)
    for (int j = array.GetLength(1) - 1; j < array.GetLength(1); j++)
        array[i, j] = i + 4;

for (int i = array.GetLength(0) - 1; i < array.GetLength(0); i++)
    for (int j = 2; j > -1; j--)
    {
        array[i, j] = count;
        count++;
    }

for (int i = 2; i > 0; i--)
    for (int j = 0; j > -1; j--)
    {
        array[i, j] = count;
        count++;
    }

for (int i = 1; i > 0; i--)
    for (int j = 1; j < array.GetLength(1) - 1; j++)
    {
        array[i, j] = count;
        count++;
    }

for (int i = 2; i < array.GetLength(0) - 1; i++)
    for (int j = 2; j > 0; j--)
    {
        array[i, j] = count;
        count++;
    }

PrintArray(array);

void PrintArray(int[,] array, string title = " ")
{
    if (title != " ")
        Console.Write($"{title}\n");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],2} ");
        }
        Console.WriteLine();
    }
}