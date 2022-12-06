/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/

/*double[,] Create2dArray(int row, int column)
{
    double[,] new2dArray = new double[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            new2dArray[i, j] = new Random().Next(1,100) + Math.Round(new Random().NextDouble(),3);
    return new2dArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}*/

/*Console.Write("Input qnt of rows in array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input qnt of columns in array: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] numbers2d = Create2dArray(m, n);
Show2dArray(numbers2d);*/


/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.*/

/*void Position (double [,] array, int i, int j)
{
if (i > array.GetLength(0) || j > array.GetLength(1))
    Console.Write("There is no such a position in array.");
else Console.Write($"The number under indexes [{i}, {j}] is {array[i, j]}.");
}

Console.Write("Input qnt of rows in array: ");
int arrayRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input qnt of columns in array: ");
int arrayColumns = Convert.ToInt32(Console.ReadLine());

double [,] newArray = Create2dArray(arrayRows, arrayColumns);
Show2dArray(newArray);
Console.WriteLine();

Console.Write("Input row's index of array: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Input column's index of array: ");
int j = Convert.ToInt32(Console.ReadLine());

Position(newArray, i, j);*/


/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.*/


int[,] Create2dArray(int row, int column)
{
    int[,] new2dArray = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            new2dArray[i, j] = new Random().Next(1, 10);
    return new2dArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


double[] Average(int[,] array)
{
    double[] avrSum = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double avr = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avr += array[i, j];
        }
        avrSum[j] = Math.Round((avr / array.GetLength(0)), 2);
    }
return avrSum;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");
}


Console.Write("Input qnt of rows in array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input qnt of columns in array: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] numbers2d = Create2dArray(m, n);
Show2dArray(numbers2d);
double [] newArray = Average(numbers2d);
ShowArray(newArray);