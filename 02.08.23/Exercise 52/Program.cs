// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2  [0,0]
// 5 9 2 3  [1,0]
// 8 4 2 4  [2,0]
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;

void GetAverage(double[,] inArray)
{
    double result = 0;
    Write($"Среднее арифметическое каждого столбца: ");
    for (int column = 0; column < inArray.GetLength(1); column++)
    {
        result = 0;
        for (int row = 0; row < inArray.GetLength(0); row++)
        {
            result += inArray[row, column];
        }
        if (column != inArray.GetLength(1) - 1) Write($"{Math.Round(result / inArray.GetLength(0), 2)} : ");
        else Write($"{Math.Round(result / inArray.GetLength(0), 2)}");
    }
}

double[,] GetArray(int m, int n, int minRange, int maxRange)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random random = new Random();
            result[i, j] = Convert.ToDouble(new Random().Next(0, 9));
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
    WriteLine($"Ошибка : Введено отрицательное число или '0' : {rows} , {columns}");
    return;
}

double[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);
WriteLine();
GetAverage(array);