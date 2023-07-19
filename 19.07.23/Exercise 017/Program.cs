Console.Clear();

// Задача 15: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter number of day of the week: ");
int numberOfDayOfWeek = int.Parse(Console.ReadLine());

if (numberOfDayOfWeek > 0 && numberOfDayOfWeek < 8)
{
    if (numberOfDayOfWeek == 6 || numberOfDayOfWeek == 7) 
    Console.WriteLine($"{numberOfDayOfWeek} -> Holiday!!!");
    else Console.WriteLine($"{numberOfDayOfWeek} -> Go to work D:");
}
else Console.WriteLine("Enter number of day of the week please");