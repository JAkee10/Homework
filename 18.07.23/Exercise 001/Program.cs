/*
Задача 4: Напишите программу, 
которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Clear();

Console.Write("a:");
int num1 = int.Parse(Console.ReadLine());
Console.Write("b:");
int num2 = int.Parse(Console.ReadLine());
Console.Write("c:");
int num3 = int.Parse(Console.ReadLine());

if (num1 >= num2 && num1 >= num3)
{
    Console.Write($"Maximum number is: {num1}");
}
else if (num2 >= num1 && num2 >= num3)
{
    Console.Write($"Maximum number is: {num2}");
}
else
{
    Console.Write($"Maximum number is: {num3}");
}