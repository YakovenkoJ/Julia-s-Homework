﻿/*Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.*/

/*int ShowDec (int num)
{
    int dec = num % 100;
    int new_num = dec / 10;
    return new_num;
}

Console.Write("Enter three-digit number: ");
int user_num = Convert.ToInt32(Console.ReadLine());
int result = ShowDec(user_num);
Console.WriteLine($"The second digit of your number is {result}");*/

/*Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.*/

void DayOFF (int num)
{
    if (num == 6 || num == 7)
    {
        Console.WriteLine("Сегодня выходной!");
    }
    else Console.WriteLine("Сегодня рабочий день!");
}

Console.Write("Enter number from 1 to 7: ");
int user_num = Convert.ToInt32(Console.ReadLine());
if (user_num >= 1 && user_num <=7)
    {
        DayOFF(user_num);
    }
else Console.Write("Incorrect number's format.");