/*Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.*/

/*int [] CreateNewArray (int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(1,100);
    return array;
}

void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int array_size = 8;
int[] numbers = CreateNewArray (array_size);
ShowArray(numbers);*/


/*Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.*/

int Exponentation (int a, int b)
{
    int res = a;
    for(int count = 1; count < b; count++)
    {
        res = res * a;
    }
    return res;
}

Console.Write("Input A: ");
int user_A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input B: ");
int user_B = Convert.ToInt32(Console.ReadLine());
int result = Exponentation(user_A, user_B);
Console.WriteLine($"{user_A} ^ {user_B} = {result}.");

