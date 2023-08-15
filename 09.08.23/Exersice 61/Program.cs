// Задача 61
// Показать треугольник Паскаля. *Сделать вывод в виде равнобедренного треугольника.

using System;
using static System.Console;

Clear();

int row = 0;
int column = 1;

int[,] GetArray(int length)
{
    int[,] array = new int[length, length];
    for (int i = 0; i < array.GetLength(row); i++)
    {
        for (int j = 0; j < array.GetLength(column); j++)
        {
            array[i, j] = 0;
        }
    }
    array[0, 0] = 1;
    return array;
}

/*
                                        Вариант решения с выводом массива:

int[,] GetPascalTriangle(int length)
{
    int[,] array = new int[length, length];
    for (int i = 0; i < length; i++)
    {
        array[i, 0] = 1;
    }
    for (int i = 1; i < length; i++)
    {
        for (int j = 1; j < length; j++)
        {
            array[i, j] = array[i - 1, j] + array[i - 1, j - 1];
        }
    }
    return array;
}

*/

int[,] GetPascalTriangle(int length)
{
    int[,] array = new int[length, length];
    array[0, 0] = 1;

    for (int i = 1; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            if (j == 0) array[i, j] = 1;
            else
            {
                array[i, j] = array[i - 1, j] + array[i - 1, j - 1];
            }
        }
    }
    return array;
}

void PrintPascalTriangle(int[,] inArr)
{
    for (int i = 0; i < inArr.GetLength(row); i++)
    {
        for (int j = inArr.GetLength(row); j > i; j--)
        {
            Write($"     ");
        }
        for (int j = 0; j < inArr.GetLength(column); j++)
        {
            
            if (inArr[i, j] != 0)
            {
                Write($"    {inArr[i, j]}    ");
            }
        }
        WriteLine();
    }
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


Write($"Введите количество строк массива: ");
int rowsCount = Convert.ToInt32(ReadLine());

Clear();

int[,] array = GetPascalTriangle(rowsCount);
PrintPascalTriangle(array);
