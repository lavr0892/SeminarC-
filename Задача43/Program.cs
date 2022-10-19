//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите первую координату: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите вторую координату: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третью координату: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите четвертую координату: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b1 - b2) / (k2 - k1);
double y = k1 * x + b1;
double y1 = k2 * x + b2;
b1 = Math.Abs(b1);
k1 = Math.Abs(k1);
b2 = Math.Abs(b2);
k2 = Math.Abs(k2);

if (y == y1)
Console.WriteLine($"Координаты точки пересечения пересечения: y({y}), x({x})");

else
Console.WriteLine("Точки пересечения нет");