// Задача 27: Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

Console.Write("Enter the number : ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
Console.Write($"The sum of digits in this number {number} -> ");

while (number > 0)
{
    result = result + (number % 10);
    number = number / 10;
}

Console.WriteLine($"{result}");