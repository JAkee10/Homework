// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using System;
using static System.Console;

int[,,] GetArray(int a, int b, int c)
{
    int[,,] inArray = new int[a, b, c];
    int number = 10;
    for (int i = 0; i < inArray.GetLength(2); i++)
    {
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            for (int k = 0; k < inArray.GetLength(1); k++)
            {
                inArray[j, k, i] = number++;
            }
        }
    }
    return inArray;
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(2); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                Write($"{arr[j, k, i]}({j},{k},{i}) ");
            }
            WriteLine();
        }
        WriteLine();
    }
}

Clear();

int[,,] array = GetArray(2, 2, 2);
PrintArray(array);