/*    Задача 45: Напишите прошрамму, которая будет создавать копию заданного 
массива с помощью поэлементного копирования    */

Console.Clear();
int[] copyArray = GetArray();
int[] pasteArray = CopyPasteArray(copyArray);
Console.WriteLine($"Массив copyArray : [{String.Join(", ", copyArray)}], успешно скопирован в массив pasteArray : [{String.Join(", ", pasteArray)}]");

int[] GetArray()
{
    Console.Write($"Введите числа для массива через запятую ',' : ");
    int[] nums = Console.ReadLine().Split(',')
                             .Select(e => int.Parse(e))
                             .ToArray();
    return nums;
}

int [] CopyPasteArray(int[] copy)
{
    int[] paste = new int[copy.Length];
    for (int i = 0; i < copy.Length; i++)
        paste[i] = copy[i];
    return paste;
}