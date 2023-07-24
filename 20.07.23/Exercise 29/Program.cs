// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();

int[] array = new int[new Random().Next(1, 11)];

Console.Write($"Array content : [");
for (int i = 0; i < array.Length - 1; i++)
{
    array[i] = new Random().Next(100);
    Console.Write($"{array[i]}, ");
}
array[array.Length - 1] = new Random().Next(100);
Console.WriteLine($"{array[array.Length - 1]}]");
Console.Write($"Array's length is {array.Length}");