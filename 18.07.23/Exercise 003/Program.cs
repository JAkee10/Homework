Console.Clear();

Console.Write("Enter three-digit number: ");
int number = int.Parse(Console.ReadLine());
int lastDigit = 0;

if (number / 100 >= 1)
{
    lastDigit = number % 10;
    Console.Write($"Last digit in the number it's: {lastDigit}");
}
else
{
    Console.Write("Restart and enter three-digit number please!");
}