// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int GetSum(int M, int N)
{
    if (M == N)
    {
        return N;
    }
    return M + GetSum(M + 1, N);
}



Console.Clear();

Console.Write($"Введите первое число: ");
int minNumber = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите второе число: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());
if (maxNumber < 0 || minNumber < 0) 
{
    Console.WriteLine("Введено отрицательное число");
    maxNumber = 0;
    minNumber = 0;
}
else if (minNumber > maxNumber)
{
    int temp = minNumber;
    minNumber = maxNumber;
    maxNumber = temp;
}

Console.WriteLine();

Console.WriteLine($"Результат: {GetSum(minNumber, maxNumber)}");