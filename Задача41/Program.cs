
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3



void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)

        array[i] = new Random().Next(-1000, 1000);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int count = 0;
FillArray(array);
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        count++;
}


Console.WriteLine("Массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество чисел больше 0: {count} ");