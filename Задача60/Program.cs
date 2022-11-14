//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

void InputMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        { 
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(0, 11);
                Console.Write($"{matrix[i, j, k]} \t");
            }      
        }
        Console.WriteLine();
    }
}

void PrintMatrix(int[,,] MatrixOne)
{
    for (int i = 0; i < MatrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixOne.GetLength(1); j++)
        {
            for(int k = 0; k < MatrixOne.GetLength(2); k++)
            {
                MatrixOne[i, j, k] = new Random().Next(0, 11);
                Console.WriteLine(MatrixOne[i, j, k] + " (" + i + ", " + j + ", " + k + ")"); 
            }
        }  

    }  
        
}

Console.Clear();
Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z: ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] MatrixOne = new int[x, y, z];
InputMatrix(MatrixOne);
PrintMatrix(MatrixOne);
