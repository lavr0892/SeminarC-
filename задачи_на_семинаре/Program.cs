/*  
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
    }
}


void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
    Console.WriteLine();
    }
}
void ReleaseMatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
            if (i == j)
            sum = matrix[i, j] + matrix[i, j];
            Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
ReleaseMatrix(matrix);
PrintMatrix(matrix);
*/

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
int n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите количество строк: ");
int m = Convert.ToDouble(Console.ReadLine());

InputMatrix(matrix);
Console.WriteLine("Массив:");
PrintMatrix(matrix);