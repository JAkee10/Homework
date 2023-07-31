/*
Задача 8: Напишите программу, 
которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/


Console.Clear();

int i = 2;
Console.Write("Enter positive number: ");
int N = int.Parse(Console.ReadLine());

if (N > 0)
{
    while (i < N)
    {
        Console.Write($"{i} ");
        i += 2;
    }
}
else
{
    Console.Write("Restart and enter positive number please!");
}