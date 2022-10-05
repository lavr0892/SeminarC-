

// Вариант 2
/*
Console.Clear();
Console.WriteLine("Введите трехзначное число ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Второе число {n % 100 / 10}");

*/
Console.Clear();
Console.WriteLine("Введите трехзначное число ");
int n = Convert.ToInt32(Console.ReadLine());

if (n >=100 && n <=999)
    n = n % 100 / 10;

Console.WriteLine(n);

//if (n < 100 && n > 999)
//Console.WriteLine("Введено не трехзначное число");