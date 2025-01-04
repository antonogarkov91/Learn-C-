//Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.WriteLine("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 10)
{
    Console.WriteLine(N);
}
else
{
    while (N > 0)
    {
        int N1 = N % 10;
        N /= 10;
        if (N > 0)
        {
            Console.Write(N1 + ",");
        }
        else
        {
            Console.WriteLine(N1);
        }
    }
}

//Пример:
// N = 456
// while N > 0
// N1 = N % 10 = 456 % 10 = 6
// N = N / 10 = 456 / 10 = 45
// if N > 0 (45 > 0)
// Console.Write(N1 + ",")
// 6,

// N = 45
// while n > 0
// N1 = N % 10 = 45 % 10 = 5
// N = N / 10 = 45 / 10 = 4
// if (N > 0) (4 > 0)
// Console.Write(N1 + ",")
// 5,

// N = 4
// N1 = N % 10 = 4 % 10 = 4
// N = N / 10 = 4 / 10 = 0
// if (N > 0) (0 !> 0)
// Console.Write(N1)
// 4

// End 6,5,4
