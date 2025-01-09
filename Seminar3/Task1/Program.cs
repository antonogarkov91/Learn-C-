// Создайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры:
// [1 3 4 19 3], 8 => нет
// [-4 3 4 1], 3 => Да

Console.Clear();
Console.Write("введите длину массива: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = new int[x];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11);

Console.WriteLine(string.Join(", ", array));

int k = new Random().Next(1, 11);
Console.WriteLine(k);

bool flag = false;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == k)
       {
            flag = true;
            Console.WriteLine("yes");
            break;
       }
}
if (flag == false)
    Console.WriteLine("no");
