// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


string GetNumbers(int N)
{
    if (N < 1) return "0";
    else if (N == 1)
    {
        return "1";
    }
    return N.ToString() + ", " + GetNumbers(N - 1);
}



Console.Clear();

Console.Write($"Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Результат: {GetNumbers(n)}");