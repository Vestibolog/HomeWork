/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
натуральные числа в промежутке от M до N.
M = 6; N = 2. -> "6, 5, 4, 3, 2"
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"
*/

Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());


void SomeRec(int m, int n)
{
    Console.Write($" {m}");

    if (m == n)
    {
        return;
    }
    else if (m < n)
    {
        SomeRec(m + 1, n);
    }
    else SomeRec(m - 1, n);
}

SomeRec(m, n);