/*Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

int[] CreateArray()
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
Console.Write($"Sum of elements > 0 is {result}.");