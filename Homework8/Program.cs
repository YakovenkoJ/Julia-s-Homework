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

/*Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/

void SortMaxMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int s = 0; s < array.GetLength(1) - 1; s++)
            {
                if (array[i, s] < array[i, s + 1])
                {
                    int temp = array[i, s + 1];
                    array[i, s + 1] = array[i, s];
                    array[i, s] = temp;
                }
            }
    Show2dArray(array);
}


int[,] numbers = Create2dArray(4, 3);
Show2dArray(numbers);
SortMaxMin(numbers);

