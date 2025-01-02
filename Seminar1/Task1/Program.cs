// Console.WriteLine("Введите чило: ");
// int f = Convert.ToInt32(Console.ReadLine());
// Console.Write(f + 10);

// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

Console.Clear();
Console.WriteLine("Введите чило № 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число № 2: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");