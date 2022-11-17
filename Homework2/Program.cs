/*Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.*/

int ShowDec (int num)
{
    int dec = num % 100;
    int new_num = dec / 10;
    return new_num;
}

Console.Write("Enter three-digit number: ");
int user_num = Convert.ToInt32(Console.ReadLine());
int result = ShowDec(user_num);
Console.WriteLine($"The second digit of your number is {result}");
