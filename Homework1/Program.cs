/*Console.WriteLine("Hello, World!");*/

/*Задача 2. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
Мой комментарий: Делала попытку после "защиты от дурака" сразу отправить на запрос "Введите первое число" - не получилось, к сожалению.
Только снова на запуск программы.*/

/*Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2)
{
    Console.Write("Числа равны");
}
else
{   if (num1 > num2)
{
    Console.Write($"Max = {num1}, Min = {num2} ");
}
else 
{
    Console.Write($"Max = {num2}, Min = {num1} ");
}
}
*/

/*Задача 4. Напишите программу, которая принимает на вход 3 числа и выдает максимальное из этих чисел.*/

/*Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int Max = num1;
if (Max < num2)
{
    Max = num2;
}
   if (Max < num3)
   {
    Max = num3;
   }
Console.Write($"Max = {Max}");
*/

/*Задача 6. Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на 2 без остатка).*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)

{
    Console.Write($"Число {number} четное");
}
else
{
    Console.Write($"Число {number} нечетное");
}