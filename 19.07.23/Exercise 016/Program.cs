// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.Write("Enter number : ");
string stringNum = Console.ReadLine();
int num = int.Parse(stringNum);
 
if (num / 100 != 0) Console.Write($"Third digit in {num} -> {stringNum[2]}");
else Console.Write($"Number {num} don't have third digit");
