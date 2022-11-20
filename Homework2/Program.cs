/*Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.*/

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

/*void DayOFF (int num)
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
else Console.Write("Incorrect number's format.");*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.*/

void Digits (int num)
{   
    int current = num;
    int count_length = 0;
    while (current != 0)
    {
            current = current / 10;
            count_length ++;
    }
    if (count_length < 3)
    {
        Console.Write("There is no 3rd digit in your number.");
    }
    else if (count_length == 3)
    {
        num = num % 10;
        Console.Write($"The 3rd digit in your number is {num}.");
    }
    else
    {
        count_length = count_length -3;
        while (count_length != 0)
        {
            num = num / 10;
            count_length = count_length - 1;
        }
        num = num % 10;
        Console.Write($"The 3rd digit in your number is {num}.");
    }
}

Console.Write("Enter your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());
Digits (user_num);