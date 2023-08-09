// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

/*
C[0,0] = 18 # = 2 4 | 3 #      C[0,0] += A[0,i] * B[i,0]; i++
          # #   # # | 3 #      C[0,0] += A[0,i] * B[i,0] 

C[0,1] = # 20 = 2 4 | # 4      C[0,1] += A[0,i] * B[i,1]; i++
         # #    # # | # 3      C[0,1] += A[0,i] * B[i,1] 

          # #   # # | 3 #      C[1,0] += A[1,i] * B[i,0]; i++
C[1,0] = 15 # = 3 2 | 3 #      C[1,0] += A[1,i] * B[i,0]
*/

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

int GetRowsCount()
{
    Write($"Введите количество строк массива: ");
    return Convert.ToInt32(ReadLine());
}

int GetColumnsCount()
{
    Write($"Введите количество столбцов массива: ");
    return Convert.ToInt32(ReadLine());
}

int[,] GetMatrixProduct(int[,] inArrayA, int[,] inArrayB)
{
    int[] minArrayBorder = new int[2];
    for (int i = 0; i < minArrayBorder.Length; i++)
    {
        minArrayBorder[i] = (inArrayA.GetLength(i) < inArrayB.GetLength(i)) ? inArrayA.GetLength(i) : inArrayB.GetLength(i);
    }

    int[,] matrixProduct = new int[minArrayBorder[0], minArrayBorder[1]];
    for (int i = 0; i < matrixProduct.GetLength(0); i++)
    {
        for (int j = 0; j < matrixProduct.GetLength(1); j++)
        {
            for (int counter = 0; counter < matrixProduct.GetLength(0); counter++)
            {
                matrixProduct[i, j] += inArrayA[i, counter] * inArrayB[counter, j];
            }
        }
    }
    return matrixProduct;
}




WriteLine($"Массив A: ");
int[,] arrayA = GetArray(GetRowsCount(), GetColumnsCount(), 1, 9);
Clear();
WriteLine($"Массив B: ");
int[,] arrayB = GetArray(GetRowsCount(), GetColumnsCount(), 1, 9);
Clear();

WriteLine($"Массив A: ");
PrintArray(arrayA);

WriteLine($"Массив B: ");
PrintArray(arrayB);

int[,] arrayC = GetMatrixProduct(arrayA, arrayB);

WriteLine();

WriteLine($"Массив C (произведение массивов A и B): ");
PrintArray(arrayC);