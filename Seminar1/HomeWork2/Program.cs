// Задание 2.
// Поиск среднего из трех чисел.
// Напишите метод, который принимает на вход три числа и возвращает
// среднее из этих чисел (то есть не самое большое и не самое маленькое)
// Пример:
// На входе:
// a: 5
// b: 3
// c: 8
// На выходе:
// 5

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if ((a >= b && a <= c) || (a >= c && a <= b))
    Console.WriteLine(a);
else if ((b >= a && b <= c) || (b >= c && b <= a))
    Console.WriteLine(b);
else
    Console.WriteLine(c);