// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortArray(int[,] array)
{
    int columnLength = array.GetLength(0);
    int rowLength = array.GetLength(1);
    
    for (int i = 0; i < columnLength; i++)
    {
        for (int counter = rowLength - 1; counter != 0; counter--)
        {
            for (int j = 1; j < rowLength; j++)
            {
                if (array[i, j - 1] < array[i, j])
                {
                    int temp = array[i, j - 1];
                    array[i, j - 1] = array[i, j];
                    array[i, j] = temp;
                }
            }
            }
    }
}

Write($"Введите количество строк массива: ");
int rowsCount = Convert.ToInt32(ReadLine());
Write($"Введите количество столбцов массива: ");
int columnsCount = Convert.ToInt32(ReadLine());

int[,] array = GetArray(rowsCount, columnsCount, 10, 99);
PrintArray(array);

WriteLine();
SortArray(array);

PrintArray(array);



