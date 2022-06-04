/*
Задача 73: Есть число N. Сколько групп M, можно получить при разбиении всех
чисел на группы, так чтобы в одной группе все числа были взаимно просты (все
числа в группе друг на друга не делятся)? Найдите M при заданном N и получите
одно из разбиений на группы N ≤ 10²⁰.
25 мин
Например, для N = 50, M получается 6
- Группа 1: 1
- Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47
- Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
- Группа 4: 8 12 18 20 27 28 30 42 44 45 50
- Группа 5: 7 16 24 36 40
- Группа 6: 5 32 48

Другой пример разбиения на группы с тем же N:
- Группа 1: 1
- Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
- Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
- Группа 4: 8 12 18 20 27 28 30 42 44 45 50
- Группа 5: 16 24 36 40
- Группа 6: 32 48
*/
int n = 50;
int[] arrayOfstartIndex = new int[n + 1];

int[] MakeGroups(int n, int[] arrayOfstartIndex)
{
    if (n == 1)
    {
        arrayOfstartIndex[1] = 1;
        return arrayOfstartIndex;
    }
    else if (n == 2)
    {
        arrayOfstartIndex[1] = 1;
        arrayOfstartIndex[2] = 2;
        return arrayOfstartIndex;
    }
    else
    {
        int max = 0;
        arrayOfstartIndex = MakeGroups(n - 1, arrayOfstartIndex);
        for (int i = 0; i <= n; i++)
        {
            if (max < arrayOfstartIndex[i]) max = arrayOfstartIndex[i];
        }
        bool notSimple = true;
        for (int i = 1; i <= max; i++)
        {
            bool flag = false;
            for (int j = 0; j <= n; j++)
            {
                if ((arrayOfstartIndex[j] == i) && (n % j == 0))
                {
                    flag = true;
                }
            }
            if (!flag)
            {
                arrayOfstartIndex[n] = i;
                notSimple = false;
                break;
            }
        }
        if (notSimple)
        {
            arrayOfstartIndex[n] = max +1;
        }
        return arrayOfstartIndex;
    }
}


arrayOfstartIndex = MakeGroups(n, arrayOfstartIndex);
int max = 0;
for (int i = 0; i < arrayOfstartIndex.GetLength(0); i++)
{
    if (max < arrayOfstartIndex[i])
    {
        max = arrayOfstartIndex[i];
    }
}
for (int i = 1; i <= max; i++)
{
    Console.Write($"{i}- ");
    for (int j = 0; j < arrayOfstartIndex.GetLength(0); j++)
    {
        if (arrayOfstartIndex[j] == i)
        {
            Console.Write($"{j} ");
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"Всего {max} групп ");
