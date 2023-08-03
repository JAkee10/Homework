// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;
using static System.Console;

int[,] GetArray(int m, int n, int minRange, int maxRange)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random random = new Random();
            result[i, j] = random.Next(minRange, maxRange + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
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

int GetNumber(int[,] inArray)
{
    int number = 0;
    Write($"Введите номер строки на которой находится число что вам нужно: ");
    int rowID = Convert.ToInt32(ReadLine());
    Write($"Введите номер столбца на котором находится число что вам нужно: ");
    int columnID = Convert.ToInt32(ReadLine());
    if (rowID - 1 < 1 || columnID - 1 < 1)
    {
        WriteLine($"Ошибка : Введено отрицательное число : {rowID} , {columnID}");
        return 0;
    }
    if (rowID <= inArray.GetLength(0) - 1 && columnID <= inArray.GetLength(1) - 1)
    {
        number = inArray[rowID - 1, columnID - 1];
        WriteLine($"Число в массиве с координатами [{rowID}, {columnID}] => {number}");
        return number;
    }
    else
    {
        WriteLine($"ОШИБКА : В массиве отсутсвует ячейка с идексом [{rowID}, {columnID}]");
        return 0;
    }
}

Clear();
Write($"Введите количество строк в массиве: ");
int rows = Convert.ToInt32(ReadLine());
Write($"Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(ReadLine());
if (rows < 1 || columns < 1)
{
    WriteLine($"Ошибка : Введено отрицательное число : {rows} , {columns}");
    return;
}

int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);
WriteLine();
int inArrayNumber = GetNumber(array);