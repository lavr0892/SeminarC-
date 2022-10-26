// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-100, 101);

    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


Console.WriteLine("Введите первый индекс: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй индекс массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[10, 10];

InputMatrix(matrix);
PrintMatrix(matrix);
if (n > matrix.GetLength(0) && m > matrix.GetLength(1))
    Console.WriteLine("Такого элемента нет");
else
    Console.WriteLine($"На позиции {n},{m} содержится элемент {matrix[n, m]}");