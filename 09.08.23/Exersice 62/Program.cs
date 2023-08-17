// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;
using static System.Console;

const int row = 0;
const int column = 1;

Write($"Введите количество строк массива: ");
int rows = Convert.ToInt32(ReadLine());
Write($"Введите количество столбцов массива: ");
int columns = Convert.ToInt32(ReadLine());

int leftBorder = 0;
int topBorder = 0;
int rightBorder = columns - 1;
int downBorder = rows - 1;

int num = 1;
int coord = 0;
int tempCoord = 0;

int[,] GetArray(int rowsCount, int columnsCount)
{
    int[,] array = new int[rowsCount, columnsCount];
    for (int i = 0; i < rowsCount; i++)
    {
        for (int j = 0; j < columnsCount; j++)
        {
            array[i, j] = 0;
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

void LeftToRight(int[,] arr)
{
    for (int i = leftBorder; i <= rightBorder; i++)
    {
        arr[coord, i] = num++;
        tempCoord = i;
    }
    topBorder++;
    coord = tempCoord;
}

void TopToDown(int[,] arr)
{
    for (int i = topBorder; i <= downBorder; i++)
    {
        arr[i, coord] = num++;
        tempCoord = i;
    }
    rightBorder--;
    coord = tempCoord;
}

void RightToLeft(int[,] arr)
{
    for (int i = rightBorder; i >= leftBorder; i--)
    {
        arr[coord, i] = num++;
        tempCoord = i;
    }
    downBorder--;
    coord = tempCoord;
}

void DownToTop(int[,] arr)
{
    for (int i = downBorder; i >= topBorder; i--)
    {
        arr[i, coord] = num++;
        tempCoord = i;
    }
    leftBorder++;
    coord = tempCoord;
}

void FillArray(int[,] inArr, int rowsCount, int columnsCount)
{
    inArr[0, 0] = 1;

    while (num != rowsCount * columnsCount + 1)
    {
        LeftToRight(inArr);
        TopToDown(inArr);
        RightToLeft(inArr);
        DownToTop(inArr);
    }
}


int[,] array = GetArray(rows, columns);

Clear();
PrintArray(array);

WriteLine();

FillArray(array, rows, columns);
PrintArray(array);