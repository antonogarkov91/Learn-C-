// Найдите произведения пар чисел в одномерном масииве. Парой
// считавем первый и последний элемент, втоой и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример:
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

Console.Clear();
Console.Write("введите длину массива: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = new int[x];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11);
Console.WriteLine(string.Join(", ", array));

int[] new_array = new int[array.Length / 2];
for (int i = 0; i < array.Length / 2; i++)
    new_array[i] = array[i] * array[array.Length - 1 - i];

Console.WriteLine(string.Join(", ", new_array));

//  0 1 2 3 4 5
// [1 3 2 4 2 3]

// array[0] * array[array.Length - 1 -0]
// array[1] * array[array.Length - 1 -1]
// array[2] * array[array.Length - 1 -2]
// array[3] * array[array.Length - 1 -3]