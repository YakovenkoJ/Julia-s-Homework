/*Console.WriteLine("Hello, World!");*/

/*Задача 2. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
Мой комментарий: Делала попытку после "защиты от дурака" сразу отправить на запрос "Введите первое число" - не получилось, к сожалению.
Только снова на запуск программы.*/

Console.Write("Введите первое число: ");
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
