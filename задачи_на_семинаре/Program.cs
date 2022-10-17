void FillArrayRondomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        //Console.Write($"[{string.Join( ", ", numbers)}]");
       Console.Write(numbers[i] + " ");
    }
}

Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if(i % 2 != 0)
    sum = sum + numbers[i];
    else
    break;    
}

FillArrayRondomNumbers(numbers);
Console.WriteLine("Массив:");
PrintArray(numbers);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечётных позициях: {sum}");
