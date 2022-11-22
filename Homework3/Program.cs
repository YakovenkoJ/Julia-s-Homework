/* Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/

/*void Cube (int num)
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
else Console.WriteLine("Incorrect number's format");*/


/*Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.*/

double LongLine(int x1, int y1, int x2, int y2, int z1, int z2)
{
    int X = x2 - x1;
    int Y = y2 - y1;
    int Z = z2 - z1;
    double lengthAB = Math.Round(Math.Sqrt(X*X + Y*Y + Z*Z), 2);
    return lengthAB;
}

Console.Write("Введите x-координаты точки A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y-координаты точки A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z-координаты точки A: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите x-координаты точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y-координаты точки B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z-координаты точки B: ");
int zB = Convert.ToInt32(Console.ReadLine());

double distance = LongLine(xA, yA, xB, yB, zA, zB);

Console.Write($"Расстояние между точками: {distance}.");