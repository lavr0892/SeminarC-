Console.Clear();
Console.WriteLine("Введите число, соответствующее одному из дней недели: Понедельник: 1, Вторник: 2, Среда: 3, Четверг: 4, Пятница: 5, Суббота: 6, Воскресенье: 7 ");
int n = Convert.ToInt32(Console.ReadLine());

int[] week = {1, 2, 3, 4, 5, 6, 7};
if (n > 5 && n < 8)
  Console.WriteLine("Выходной день");

if (n >= 1 && n <= 5)
  Console.WriteLine("Рабочий день");
  
if (n > 7)
  Console.WriteLine("Введено число, не входящее в диапазон от 1 до 7");