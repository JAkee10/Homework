// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int A(int m, int n)
{
    if (m < 0 || n < 0) 
    {
        Console.WriteLine($"Введено отрицательное число, обработка невозможна");
        return 0;
    }
    else if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return A(m - 1, 1);
    }
    else
    {
        return A(m - 1, A(m, n - 1));
    }
}


Console.Clear();

Console.Write($"Введите первое неотрицательное число (m): ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите второе неотрицательное число (n): ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Результат: {A(numberM, numberN)}");