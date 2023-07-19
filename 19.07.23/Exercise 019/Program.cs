// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.Write("Enter five-digit number : ");
string intro = Console.ReadLine();
int length = intro.Length;

if (length == 5)
    if (intro[0] == intro[4] && intro[1] == intro[3])
        Console.WriteLine($"{intro} -> yes");
    else Console.WriteLine($"{intro} -> no");
else Console.WriteLine("Wrong number entered, try again");















// if (intro == 5)
// {
//     int leftDigit = intro / 10000;
//     int rightDigit = intro % 10;
//     if (leftDigit == rightDigit)
//     {
//         int middleLeftDigit = 
//         int middleRightDigit = 
//     }
// }
// else Console.WriteLine("Wrong number entered, try again");