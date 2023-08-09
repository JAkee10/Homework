// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;
using static System.Console;

Clear();

int row = 0;
int column = 1;

int[,] GetArray(int rowsCount, int columnsCount, int minValue, int maxValue)
{
    int[,] array = new int[rowsCount, columnsCount];
    for (int i = 0; i < array.GetLength(row); i++)
    {
        for (int j = 0; j < array.GetLength(column); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(row); i++)
    {
        for (int j = 0; j < inArray.GetLength(column); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

int GetMinRowSum(int[,] array)
{
    int columnLength = array.GetLength(0);
    int rowLength = array.GetLength(1);
    int[] rowSum = new int[columnLength];
    int rowSumIdOfMinimum = 0;

    for (int i = 0; i < columnLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            rowSum[i] += array[i, j];
        }
    }

    for (int i = 1; i < rowSum.Length; i++)
    {
        if (rowSum[i] < rowSum[rowSumIdOfMinimum]) rowSumIdOfMinimum = i;
    }
    return rowSumIdOfMinimum;
}

Write($"Введите количество строк массива: ");
int rowsCount = Convert.ToInt32(ReadLine());
Write($"Введите количество столбцов массива: ");
int columnsCount = Convert.ToInt32(ReadLine());

int[,] array = GetArray(rowsCount, columnsCount, 0, 3);
Clear();
PrintArray(array);

WriteLine();
int IDMinRow = GetMinRowSum(array);

WriteLine($"Строка с наименьшой суммой элементов => {IDMinRow + 1}");

