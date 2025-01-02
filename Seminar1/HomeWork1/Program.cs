Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());


if (secondNumber == 0)
    Console.WriteLine("на ноль делить нельзя");
else if (firstNumber % secondNumber == 0)
    Console.WriteLine("делится");
else
    Console.WriteLine("не делится");