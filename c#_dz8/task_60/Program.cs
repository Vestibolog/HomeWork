/*
Задача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента.
*/
int m = 3;
int n = 4;
int l = 5;
int[,,] mass = new int[m, n, l];
int tempIndex = 0;

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        for (int k = 0; k < mass.GetLength(2); k++)
        {
            tempIndex++;
            mass[i, j, k] = tempIndex;
        }

    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"Элемент i={i} j={j} k={k}  - {array[i, j, k]}");
            }
        }
    }
}

PrintArray(mass);

void PrintArray2(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
PrintArray2(mass);

