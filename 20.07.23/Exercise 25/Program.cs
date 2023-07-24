// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число A в 
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Enter A number : ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter B number : ");
double b = Convert.ToDouble(Console.ReadLine());

double res = Pow(a, b);
Console.WriteLine(res);



double Pow(double num1, double num2)
{
    double result = num1;
    for (int i = 1; i < num2; i++)
    {
        result *= num1;
    }
    return result;
}