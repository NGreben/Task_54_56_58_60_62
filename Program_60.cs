/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] array = CreateArray(2, 2, 2, 0, 100);
PrintArray(array);

int[,,] CreateArray(int row, int column, int width, int min, int max)
{
    int[,,] array = new int[row, column, width];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                array[i, j, k] = new Random().Next(min, max);
    return array;
}

void PrintArray(int[,,] array, string title = " ")
{
    if (title != " ")
        Console.Write($"{title}\n");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
}