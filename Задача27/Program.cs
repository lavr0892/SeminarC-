Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 0;
while(n > 0)
{
  int m = n % 10;
  n = n / 10; 
  result = result + m;
}
Console.WriteLine(" Сумма цифр в числе = " + result);