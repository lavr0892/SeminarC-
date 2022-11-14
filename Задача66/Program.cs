// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//(НЕ ИСПОЛЬЗОВАТЬ РЕЗУЛЬТИРУЮЩУЮ ПЕРЕМЕННУЮ)
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

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