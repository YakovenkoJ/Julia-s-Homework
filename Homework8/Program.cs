/*int[,] Create2dArray(int row, int column)
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
}*/

/*Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/

/*void SortMaxMin(int[,] array)
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
SortMaxMin(numbers);*/


/*Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

/*void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");
}*/

/*int[] SumRow(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumArray[i] = sum;
    }
    return sumArray;
}

int FindMin(int[] array)
{
    int indMin = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < array[indMin]) indMin = i;
    return indMin + 1;
}


Console.Write("Input qnt of rows in array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input qnt of columns in array: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] numbers = Create2dArray(m, n);
Show2dArray(numbers);
int[] sumRes = SumRow(numbers);
//ShowArray(sumRes);
int result = FindMin(sumRes);
Console.WriteLine();
Console.WriteLine($"The row with min sum of elements is {result}.");*/


/*Задача 60(дополнительно). Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
*/

const int cellWidth = 3;

int[,,] Create3dArray()
{
    int[,,] new3dArray = new int[2, 2, 2];
    int n = new Random().Next(10, 99);
    for (int i = 0; i < 2; i++)
        for (int j = 0; j < 2; j++)
            for (int k = 0; k < 2; k++)
                new3dArray[i, j, k] = n++;
    return new3dArray;
}

void Print3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k],cellWidth} ({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
}

Print3dArray(Create3dArray());



