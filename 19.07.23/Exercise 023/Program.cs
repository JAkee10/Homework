// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.Write("Enter N number : ");
double N = Convert.ToDouble(Console.ReadLine());

if (N > 0)
{
    Console.Write($"{N} -> ");
    for (int i = 1; i < N; i++)
        Console.Write($"{Math.Pow(i, 3)}, ");
    Console.Write(Math.Pow(N, 3));
}
else
{
    Console.WriteLine("Enter positive number!");
}