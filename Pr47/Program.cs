// Задача 47. Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] arr = new double [m,n];
for ( int i = 0; i < arr.GetLength(0); i++)
{
    for (int  j = 0; j <arr.GetLength(0); j++)
    { 
       arr[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
    }   
}
for ( int i = 0; i < arr.GetLength(0); i++)
{
    for (int  j = 0; j <arr.GetLength(0); j++)
    { 
       Console.Write(arr[i,j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
