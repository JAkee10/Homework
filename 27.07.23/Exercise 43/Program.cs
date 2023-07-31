// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = 5X + 2 -9X - 4 = -4X

Console.Clear();
double[] coordinates = GetCoordinates();
double[] interectionOfAB = coordsInterectionPoint(coordinates);
Console.WriteLine($"Координаты точки пересечения => ({(String.Join(" ; ", interectionOfAB))})");


double[] coordsInterectionPoint(double[] coords)
{
    double[] interectionPoint = new double[2];
    interectionPoint[0] = Math.Round((coords[0] - coords[1]) / (-1 * (coords[2] - coords[3])), 2);
    interectionPoint[1] = Math.Round(coords[3] * interectionPoint[0] + coords[1], 2);
    return interectionPoint;
}

double[] GetCoordinates()
{
    Console.Write("Введите четыре координаты в стиле: xA,yA : xB,yB =>");
    string[] textCoords = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);
    
    double[] coordsA = textCoords[0].Split(",")
                       .Select(el => Convert.ToDouble(el))
                       .ToArray();
    double[] coordsB = textCoords[1].Split(",")
                       .Select(el => Convert.ToDouble(el))
                       .ToArray();
    double[] coords = new double[] {coordsA[0], coordsA[1], 
                                    coordsB[0], coordsB[1]};
    return coords;
}