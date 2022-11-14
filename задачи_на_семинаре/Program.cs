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
/* 
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
 */

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*  void InputMatrix(int[,] matrix)
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

Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
*/
/* 
void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int k = new Random().Next(-1, 2);
            while (k == 0)
                k = new Random().Next(-1, 2);
            matrix[i, j] = Math.Round(new Random().NextDouble() * 10 * k, 3);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine().Split(' '); //ввод чисел в одну строку
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
double[,] matrix = new double[n, m];
InputMatrix(matrix);
 */
/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0,i];
        matrix[0,i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) -1, i] = temp;
    }

    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    } 
}

Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrix = new int[n,m];
Console.WriteLine("Begin: ");
InputMatrix(matrix);
Console.WriteLine("Result: ");
ReleaseMatrix(matrix);
  */
/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void ReleaseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
while (n != m)
{
    Console.Write("Введите кол-во строк и столбцов(кол-во строк = кол-во столбцов): ");
    num = Console.ReadLine().Split(' ');
    n = int.Parse(num[0]);
    m = int.Parse(num[1]);
}
int[,] matrix = new int[n, m];
Console.WriteLine("Begin: \n");
InputMatrix(matrix);
Console.WriteLine("Result: \n");
ReleaseMatrix(matrix);
  */


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//(НЕ ИСПОЛЬЗОВАТЬ РЕЗУЛЬТИРУЮЩУЮ ПЕРЕМЕННУЮ)
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

/*  
int ResultNumbers(int n, int m)
{

    if (n == m)
        return n;
    return m + ResultNumbers(n, m - 1);
}


Console.Clear();
Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ResultNumbers(m, n));
*/


  //Задача 68
   




int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine("Введите первое положительное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");