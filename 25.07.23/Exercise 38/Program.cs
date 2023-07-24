// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


Console.Clear();

Console.Write("Enter element of array with space: ");
string elements = Console.ReadLine();
double[] doubleArray = GetArrayFromString(elements);
Console.Clear();
double max = doubleArray[0];
double min = doubleArray[0];
for (int i = 0; i < doubleArray.Length; i++)
{
    if (doubleArray[i] > max)
        max = doubleArray[i];
    else if (doubleArray[i] < min)
        min = doubleArray[i];
}
Console.Write($"Difference of maximum and miminum elements in array [{String.Join(", ", doubleArray)}] is => {max} - {min} = {GetDifference(max, min)}");

// TODO Нужно улучшить алгоритм, чтобы так же можно было использовать отрицательные значния

double GetDifference(double max, double min)
{
    double res = max - min;   
    return res;
}

double[] GetArrayFromString(string stringArray)
{
    string[] stringNums = stringArray.Split(" ");
    double[] result = new double[stringNums.Length];

    for (int i = 0; i < stringNums.Length; i++)
    {
        result[i] = double.Parse(stringNums[i]);
    }
    return result;
}