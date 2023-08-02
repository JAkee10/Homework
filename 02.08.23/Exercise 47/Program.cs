// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;
using static System.Console;

double[,] GetArray(int m, int n, int minRange, int maxRange)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random random = new Random();
            result[i, j] = Math.Round(random.NextDouble(), 2) + random.Next(minRange, maxRange + 1);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}


Clear();
Write($"Введите количество строк в массиве: ");
int rows = Convert.ToInt32(ReadLine());
Write($"Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(ReadLine());
if (rows < 1 || columns < 1) 
{
    WriteLine($"Введено отрицательное число");
    return;
}
double[,] array = GetArray(rows, columns, -9, 9);
PrintArray(array);