//Console.Clear();
// for(int i = 5; i <= 20; i= i + 2) // for(начальное значение;конечное значение;шаг)
// {
//     Console.WriteLine(i);
// }

// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1
//1 способ:

Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while(n < 100 || n > 999)
{
    Console.Write("Ошибка! Введите трехзначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}

// 514 /10 = 51 % 10 = 1
int n2 = n / 10 % 10;
int n3 = n % 10;

int result = 1;
for (int i = 1; i <= n3; i ++)
{
    result *= n2;
}
Console.WriteLine("Loop: " + result);
Console.WriteLine(Math.Pow(n2, n3));
