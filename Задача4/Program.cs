//Console.WriteLine("Введите три числа: ");
//int na = Convert.ToInt32(Console.ReadLine());
//int nb = Convert.ToInt32(Console.ReadLine());
//int nc = Convert.ToInt32(Console.ReadLine());
//int[] numbers = {na, nb, nc};
//int max = numbers[0]; 


//for (int i = 0; i < numbers.Length; i++){
//   max = numbers[max];
//}
//Console.WriteLine(max);


//Console.WriteLine("Введите три числа: ");
//int na = Convert.ToInt32(Console.ReadLine());
//int nb = Convert.ToInt32(Console.ReadLine());
//int nc = Convert.ToInt32(Console.ReadLine());
//int num1 = na, num2 = nb, num3 = nc;
 //int max;
 //if (num1 >= num2)
 //{
    //if (num3 >= num1)
    //{
      // max = num3;
    //}
    //else
    //{
     //  max = num1;
   // }
 //}
 //else
 //{
    //if (num3 >= num2)
    //{
      // max = num3;
    //}
    //else
    //{
     //  max = num2;
   // }
 //}
 //Console.WriteLine(max);

 
 
 
 
 Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int maxi = a;
if (maxi < b)
    maxi = b;
if (maxi < c)
    maxi = c;
Console.WriteLine(maxi);
