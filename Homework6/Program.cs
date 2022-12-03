/*Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

/*int[] CreateArray()
{
    Console.Write("Input qnt of elements in array: ");
    int M = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[M];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Input element {i} of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}


int CountPos(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            sum += array[i];
    }
    return sum;
}

int [] numbers = CreateArray();
ShowArray(numbers);
int result = CountPos(numbers);
Console.Write($"Sum of elements > 0 is {result}.");*/


/*Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/

Console.Write("Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input K1: ");
double K1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input K2: ");
double K2 = Convert.ToInt32(Console.ReadLine());
if (K1 == K2)
    Console.WriteLine("Lines are parallel.");
else
{
    double x = (b2 - b1) / (K1 - K2);
    double y = K1 * x + b1;
    Console.WriteLine($"The cross point of lines has the following coordinates X:{x}; Y:{y}.");
}

