//9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8 
//12-> 2 
//85 -> 8



//Console.Clear();
//int n = new Random().Next(10, 100); // ???
//int n1 = n / 10;
//int n2 = n % 10;
//Console.WriteLine($"Сгенерированное число: {n}");

//if (n1 > n2)
  //  Console.WriteLine(n1);
//else if (n1 < n2)
  //  Console.WriteLine(n2);
//else
  //  Console.WriteLine("=");

//11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98


//Console.Clear();
//int n = Convert.ToInt32(Console.ReadLine());
//int a = 7;
//int b = 23;
//if (n % a == 0 && n % b == 0)
//    Console.WriteLine("yes");
//else
//    Console.WriteLine("no");

//Console.Clear();
//Console.WriteLine("Введите трехзначное число ");
//int n = Convert.ToInt32(Console.ReadLine());
//
//Console.WriteLine($"Второе число {n % 100 / 10}");
//  
//while (n >= 1000)
//Console.WriteLine("Вы ввели не трехзначное число");
// 
//  while (n <= 99)
//  Console.WriteLine("Вы ввели не трехзначное число");

  


/*  
Console.Clear();
Console.WriteLine("Введите трехзначное число ");
int n = Convert.ToInt32(Console.ReadLine());
int num2 = n % 100 /10;


Console.WriteLine(num2);
*/
/*
Console.Clear();
Console.WriteLine("Введите число, соответствующее одному из дней недели: Понедельник: 1, Вторник: 2, Среда: 3, Четверг: 4, Пятница: 5, Суббота: 6, Воскресенье: 7 ");
int n = Convert.ToInt32(Console.ReadLine());

int[] week = {1, 2, 3, 4, 5, 6, 7};
if (n > 5 && n < 8)
  Console.WriteLine("Выходной день");
  
if (n > 7)
  Console.WriteLine("Введено число, не входящее в диапазон от 1 до 7");

if (n >= 1 && n <= 5)
  Console.WriteLine("Рабочий день");


  */

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Можно воспользоваться нумерацией строк, но необязательно)

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
  //Задача 13
/*
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 99 && n > 1000)
Console.WriteLine("Третьей цифры нет");
  */
/*  
Console.Write("Введите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}
  */
//Console.WriteLine(n > 99 ? n.ToString()[2] : '-');
/*  
Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string nText = Convert.ToString(n);

string f(int n);
  if (n <= 99)
  return "нет третьего числа";
return "n[2]";

Console.WriteLine(f(n = n[2]));
*/

// Семинар 2
/* 
Console.Write("Введите четверть: ");
double x = Convert.ToDouble(Console.ReadLine());
double n = x > 0 && y > 0;
double y = x < 0 && y > 0; 
if (x > 0 && y > 0)
    Console.WriteLine("I");
else if (x < 0 && y > 0)
    Console.WriteLine("II");
else if (x < 0 && y < 0)
    Console.WriteLine("III");
else
    Console.WriteLine("IV");
while (x == 0)
{
    Console.Write("Введите координату х: ");
    x = Convert.ToDouble(Console.ReadLine());
}
while (y == 0)
{
    Console.Write("Введите координату y: ");
    y = Convert.ToDouble(Console.ReadLine());
}
  */
/* 
Console.Write("Введите первую координату х: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите вторую координату х: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите первую координату y: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите вторую координату y: ");
double y2 = Convert.ToDouble(Console.ReadLine());


double n = Math.Sqrt((x2 - x1)*(x2 -x1) + (y2-y1)*(y2-y1));

Console.Write(n);
  */
