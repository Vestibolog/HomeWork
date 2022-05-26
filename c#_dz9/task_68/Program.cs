/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/
int m = 3;
int n = 5;


int FunAkkerman(int m, int n)
{
    //Console.Write($" {n}");
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return FunAkkerman(m - 1, 1);
    }
    else return FunAkkerman(m - 1, FunAkkerman(m, n - 1));
}

Console.WriteLine($"ответ - {FunAkkerman(m, n)}");
