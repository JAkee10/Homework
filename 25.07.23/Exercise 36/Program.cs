// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих 
// на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write("Enter length of array : ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-100, 100);
}
Console.Write($"Count of elements on odd position in array [{String.Join(", ", array)}] is {SumOfOddArrayEl(array)}");

int SumOfOddArrayEl(int[] arr)
{
    int count = 0;
    for (int i = 1; i < arr.Length; i += 2)
        count += arr[i];
    return count;
}