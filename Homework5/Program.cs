/*Задача 34. Задайте массив, заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.*/


/*int [] CreateRandomArray (int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}


void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int CountEvenNumber (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
    return count;
}

int qnt = new Random().Next(1,30);
Console.Write(" ");
int [] numbers = CreateRandomArray (qnt);
ShowArray(numbers);
int result = CountEvenNumber(numbers);
Console.WriteLine($"Count of even numbers is {result}.");*/


/*Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.*/


/*int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}


void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int Sum (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 == 0) sum += array [i];
    return sum;
}

Console.Write("Input qnt of elements in array: ");
int size_array = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value of array: ");
int minVal= Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value of array: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

int [] numbers = CreateRandomArray(size_array, minVal, maxVal);
ShowArray(numbers);
int result = Sum(numbers);
Console.Write($"Sum of elements on even indexes is {result}.");*/


/*Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.*/

double [] CreateRandomArray (int size)
{
    double [] array = new double [size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(1,100) + Math.Round(new Random().NextDouble(),3);
    return array;
}


void ShowArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

double Difference (double [] array)
{
    double min = array [0];
    double max = array [1];
    double result;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] < min)
        {
            min = array [i];
        }
        else if (array [i] > max)
        {
            max = array[i];
        }
    }
    result = max - min;
    return result;
}

int size_array = 5;
Console.Write("   ");
double [] numbers = CreateRandomArray(size_array);
ShowArray(numbers);
double res = Math.Round(Difference(numbers), 3);
Console.WriteLine($"Difference b/w max & min element of array is {res}.");