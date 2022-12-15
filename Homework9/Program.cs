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

/*string Binarization(int num)
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
Console.WriteLine($"Your number {number} in binar system is {result}.");*/


/*Задача 68 (дополнительно). Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.*/

/*int A(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return A(n - 1, 1);
    else return A(n - 1, A(n, m - 1));

}

Console.Write("Input 1st positive number. Your number should be 0 >= number < 4: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2nd positive number. Your number should be 0 >= number < 4: ");
int M = Convert.ToInt32(Console.ReadLine());
int res = A(N, M);
Console.WriteLine();
Console.Write($"A(n,m) = {res}.");*/


/*Задача 66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.*/

int Sum(int M, int N)
{
    int sum = 0;
    if (M > N) return 0;
    else return sum = (M + Sum(M + 1, N));
}

Console.Write("Input 1st positive number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 1st positive number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m >= n) Console.Write("Incorrect input! 1st number should be < 2nd number.");
else
{
    int res = Sum(m, n);
    Console.Write($"Sum of elements b/w {m} & {n} is {res}.");
}

