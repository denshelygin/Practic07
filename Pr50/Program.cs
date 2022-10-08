// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.WriteLine("Введите позицию в строке m: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите позицию в столбце n: ");
int n = int.Parse(Console.ReadLine()!);
int[,] arr = new int [4,4];
Random myRnd = new Random();  
    if (m < arr.GetLength(0) && n < arr.GetLength(1))
    {
     Console.WriteLine(arr[m, n]);
    } 
    else
    {
     Console.WriteLine($"{m}{n} -> такого числа в массиве нет");
    } 
for ( int i = 0; i < arr.GetLength(0); i++)
{
    for (int  j = 0; j <arr.GetLength(0); j++)
    { 
       arr[i,j] = myRnd.Next(0,10);
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




