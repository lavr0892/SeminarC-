void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        
    numbers[i] = new Random().Next(1,10);       
}
void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        
    Console.Write(numbers[i] + " ");
}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
int sum = 0;

for (int i = 1; i < numbers.Length; i+=2)
    {
        sum = sum + numbers[i];
    }
 
    Console.WriteLine($"Cумма элементов на нечётных позициях = {sum}");

