//Console.WriteLine("Введите два числа: ");
//int n = Convert.ToInt32(Console.ReadLine());
//int n1 = Convert.ToInt32(Console.ReadLine());

//if (n > n1)
//Console.Write(n);
    
//else
//Console.Write(n1);

//Console.WriteLine(" Большее");


// task 2
Console.Clear();

Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
int maxi = n;
if (maxi < m)
    maxi = m;

Console.WriteLine(maxi);
