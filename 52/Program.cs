// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


//Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами\

using System;
using static System.Console;

Console.WriteLine("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());

Console.WriteLine("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());

Console.WriteLine("Введите минимальное значение элемента массива: ");
int min=int.Parse(ReadLine());

Console.WriteLine("Введите максимальное значение элемента массива: ");
int max=int.Parse(ReadLine());

double[,] array = GetArray(rows, columns, min, max);


double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double [,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble()*(maxValue-minValue)+minValue;//*(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{(inArray[i,j]):f2} ");
        }
        WriteLine();
    }
}

Console.WriteLine();
Console.WriteLine("Сформирован массив: ");
PrintArray(array);


double [] SredArifmCol (double[,] inArray)
{
  double[] SredArifmColArray =new double[inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
      for (int j = 0; j < inArray.GetLength(0); j++)
      {
        SredArifmColArray[i]=SredArifmColArray[i]+inArray[j,i]/(inArray.GetLength(0));
        SredArifmColArray[i]=Math.Round(SredArifmColArray[i], 2);
       // SredArifmColArray[i]=((SredArifmColArray[i]):f2);
      }
       
    }
    
    return SredArifmColArray;

}
double[] res1 = (SredArifmCol(array));
//Console.WriteLine(SredArifmCol1(array));
Console.WriteLine("Среднее арифмитическое каждого столбца: ");
Console.WriteLine(String.Join(" ", res1));

