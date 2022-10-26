// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
 
void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)

            matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[n, m];
InputMatrix(matrix);
Console.WriteLine("Массив:");
PrintMatrix(matrix);


