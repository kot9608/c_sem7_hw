// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// [1, 7] -> такого числа в массиве нет

//ПРИМЕЧАНИЕ!
//Индекс элемента начинается с нуля!
// Пример:
// 1 2 3
// 4 5 6
// Индекс значения 1 = 0.


using System;
using static System.Console;

Console.WriteLine("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());

Console.WriteLine("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());

int[,] array = GetArrayUser(rows, columns, 1, 9);


int[,] GetArrayUser(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine($"Введите элемент массива: Строка {i} элемент {j}");
            result[i, j] = int.Parse(ReadLine());
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}

Console.WriteLine(); 

Console.WriteLine("Введенный массив");
PrintArray(array);


void FindElement(int[,] inArray)
{
  Console.WriteLine($"Введите строку для поиска элемента(начинается с 0): ");
  int RowsFind=int.Parse(ReadLine());
  Console.WriteLine($"Введите столбецдля поиска элемента(начинается с 0): ");
  int RowsColumns=int.Parse(ReadLine());
  if (RowsFind<inArray.GetLength(0) && RowsColumns<inArray.GetLength(1))
  {
    Console.WriteLine($"Элемент с индексом [{RowsFind}, {RowsColumns}] =  {(inArray[RowsFind, RowsColumns])}");
  }
  else
  {
    Console.WriteLine($"Элемента с индексом [{RowsFind}, {RowsColumns}] в введённом массиве нет");
  }
  //return inArray[RowsFind, RowsColumns];
}

FindElement(array);