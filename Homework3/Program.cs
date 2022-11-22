/* Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/

void Cube (int num)
{
    int current = 1;
    while (current <= num)
    {
        int result = current*current*current;
        Console.Write($" {result}, ");
        current ++;
    }
    Console.WriteLine($"\b\b.");
}

Console.Write("Input your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

if (user_num >= 1)
{
    Console.Write($"{user_num} -> ");
    Cube(user_num);
}
else Console.WriteLine("Incorrect number's format");