/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());


int SomeRec(int m, int n)
{
    //Console.Write($" {n}");

    if (m == n)
    {
       return n;
    }
    else if (m < n)
    {
        return n + SomeRec(m , n -1 );
    }
    else return n + SomeRec(m , n +1 );
}

Console.WriteLine($"{SomeRec(m, n )}");