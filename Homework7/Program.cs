/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/

double[,] Create2dArray(int row, int column)
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
}

Console.Write("Input qnt of rows in array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input qnt of columns in array: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] numbers2d = Create2dArray(m, n);
Show2dArray(numbers2d);