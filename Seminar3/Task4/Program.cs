// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший - на 2-м.
// Пример:
// 456 => [6 5 4]
// 781 => [1 8 7]
Console.Clear();
int[] array = new int[3];

int k = new Random().Next(100, 1000);
Console.WriteLine(k);

for (int i = 0; i < array.Length; i++)
{ 
    array[i] = k % 10;
    k /= 10;
}

Console.WriteLine(string.Join(", ", array));

