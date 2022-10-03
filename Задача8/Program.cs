Console.WriteLine("Введите число: ");
int max = Convert.ToInt32(Console.ReadLine());
int sum = 1;
for (int i = 0; i <= max; i += 2)
    {
        Console.WriteLine(i);
        sum += i;
    }