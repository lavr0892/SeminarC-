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

Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}

//Console.WriteLine(n > 99 ? n.ToString()[2] : '-');