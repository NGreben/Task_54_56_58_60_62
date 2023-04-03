/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] array = CreateArray(3, 4, 0, 10);
PrintArray(array);
Console.WriteLine();

int[,] sortArray = array;
int temp;
for (int i = 0; i < sortArray.GetLength(0); i++)
{
    int numberSort = 0;
    while (numberSort < sortArray.GetLength(1))
    {
        for (int j = 1; j < sortArray.GetLength(1); j++)
        {
            if (sortArray[i, j - 1] < sortArray[i, j])
            {
                temp = sortArray[i, j - 1];
                sortArray[i, j - 1] = sortArray[i, j];
                sortArray[i, j] = temp;
            }
        }
        numberSort++;
    }
}

PrintArray(sortArray);

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