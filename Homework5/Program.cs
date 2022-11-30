/*Задача 34. Задайте массив, заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.*/


int [] CreateRandomArray (int size)
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
Console.WriteLine($"Count of even numbers is {result}.");