// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GetArray()
{
    Console.Write($"Введите числа для массива через запятую ',' : ");
    int[] nums = Console.ReadLine().Split(',')
                             .Select(e => int.Parse(e))
                             .ToArray();
    return nums;
}

int CountOfPosNumbers(int[] numbersArray)
{
    int i = 0;
    int count =0;
    while (i < numbersArray.Length)
    {
        if (numbersArray[i] > 0) count++;
        i++;
    }
    return count;
}


Console.Clear();
int[] array = GetArray();
int countOfPosNumbers = CountOfPosNumbers(array);
Console.Write($"В массиве [{String.Join(", ", array)}] есть {countOfPosNumbers} положительных чисел");
