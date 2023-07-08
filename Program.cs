// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] Create2DArray(int rows, int columns)
// {
//     double[,] array1 = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array1[i, j] = new Random().NextDouble() * 100;
//         }
//     }
//     return array1;
// }


// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for (int j = 0; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] array1 = Create2DArray(rows, columns);

// Print2DArray(array1);

//Math.Round(, 2) не понял как реализовать 


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}



void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
    {
        for (int j = 0; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void FindNum(int[,] array, int st, int s)
{
    if (st > array.GetLength(0) || s > array.GetLength(1))
    {
        System.Console.WriteLine($" по данной строке {st} и столбцу{s} -> вылезли за массив");
    }
    else
    {
        Console.Write($"Искомое число {array[st,s]}");
    }
} 

System.Console.WriteLine("Input number of st: ");
int st = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number of s: ");
int s = Convert.ToInt32(Console.ReadLine());


int[,] myArray = Create2DArray(5,5,1,10);

FindNum(myArray, st, s);

Print2DArray(myArray);
// Я логику понял а не понял почему не работает 

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }


// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for (int j = 0; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }


// void ArithmeticRows(int[,] array)
// {
//     double sum = 0;
//     int rows = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = (sum + array[i, j]);
//         }
//         rows++;
//         sum = sum / array.GetLength(0);
//         System.Console.WriteLine($" {rows} arithmetic mean string {sum} ");
//     }

// }

// int[,] array = Create2DArray(5, 5, 1, 10);
// ArithmeticRows(array);
// Print2DArray(array);




