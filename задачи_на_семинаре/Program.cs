// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArrayRondomNumbers(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
}

void PrintArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
       Console.Write(numbers[i] + " ");
    }
}


Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[n];
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > max)
    max = numbers[i];

    if(numbers[i] < min)
    min = numbers[i];
}


FillArrayRondomNumbers(numbers);
Console.WriteLine("Массив:");
PrintArray(numbers);
Console.WriteLine($"Максимальное число: {max}  Минимальное число: {min}");
Console.WriteLine($"Разница: {max - min}");