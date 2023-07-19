// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Enter X coordinate of point A : ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Enter Y coordinate of point A : ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Enter Z coordinate of point A : ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("Enter X coordinate of point B : ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Enter Y coordinate of point B : ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Enter Z coordinate of point A : ");
double z2 = double.Parse(Console.ReadLine());

double rangeSearch(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double result = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
    return result;
}

double range = rangeSearch(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Range => {range:f2} ({range})");