// **Задача 49:** Задайте двумерный массив.
//  Найдите элементы, у которых оба индекса чётные,
//   и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 2 3 4

// Новый массив будет выглядеть вот так:

// 1 4 7 2
// 5 **81** 2 **9**
// 8 4 2 4
// 1 **4** 3 **16**

using System;
using static System.Console;

Console.Write("Введи число строк: ");//
int M = int.Parse(Console.ReadLine());//


Console.Write("Введи число столбцов: ");//
int N = int.Parse(Console.ReadLine());//


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}


int[,] GetArraySqr(int [,] matr)
{
    
    int m = matr.GetLength(0);
    int n = matr.GetLength(1);
    int [,] matrSqr = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i%2==1 && j%2==1)
            {matrSqr[i, j] = (matr[i, j])*(matr[i, j]);}
            else
            {matrSqr[i, j] = (matr[i, j]);}
        }
    }
    return matrSqr;
}


int [,] matrix = GetArray(M, N, 1, 9);

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] matrixSqr = GetArraySqr(matrix);
PrintArray(matrix);

Console.WriteLine();

PrintArray(matrixSqr);
