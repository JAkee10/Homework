// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет количество 
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Enter length of array : ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100, 1000);
}
Console.Write($"Count of even numbers in array [{String.Join(", ", array)}] is {CountOfEvenNum(array)}");

int CountOfEvenNum(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        count += el % 2 == 0 ? 1 : 0;
    }
    return count;
}