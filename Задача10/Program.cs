
// Вариант 1
//Console.Clear();
//Console.WriteLine("Введите трехзначное число ");
//int n = Convert.ToInt32(Console.ReadLine());
//int num2 = n % 100 /10;
//
//
//Console.WriteLine(num2);


// Вариант 2
Console.Clear();
Console.WriteLine("Введите трехзначное число ");
int n = Convert.ToInt32(Console.ReadLine());

if(n > 999 && n <= 99)
Console.WriteLine("Введено не трехзначное число");

Console.WriteLine($"Второе число {n % 100 / 10}");

