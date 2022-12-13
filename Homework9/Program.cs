﻿/*Задача 64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.*/

void ShowNums(int n)
{
    Console.Write(n + " ");
    if (n > 1) ShowNums(n - 1);
}

Console.Write("Input your number: ");
int N = Convert.ToInt32(Console.ReadLine());
ShowNums(N);

