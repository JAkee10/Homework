﻿// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Clear();

int num = new Random().Next(100, 1000);
Console.WriteLine($"Number : {num}");
int middleDigit = (num % 100) / 10;
Console.Write($"Middle digit is {middleDigit}");