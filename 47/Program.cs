﻿// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



using System;
using static System.Console;

Console.WriteLine("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());

Console.WriteLine("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());

double[,] array = GetArray(rows, columns, 1, 9);


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
PrintArray(array);