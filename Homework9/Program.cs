/*Задача 64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.*/

/*void ShowNums(int n)
{
    Console.Write(n + " ");
    if (n > 1) ShowNums(n - 1);
}

Console.Write("Input your number: ");
int N = Convert.ToInt32(Console.ReadLine());
ShowNums(N);*/


/*Задача. Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.*/

string Binarization(int num)
{
    string binResult = string.Empty;
    while (num != 0)
    {
        binResult = num % 2 + binResult;
        Binarization(num /= 2);
    }
    return binResult;

}


Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
string result = Binarization(number);
Console.WriteLine($"Your number {number} in binar system is {result}.");

