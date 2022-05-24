/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов.
*/
int m = 3;
int n = 4;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
PrintArray(mass);
Console.WriteLine();

int lineWithMinSumm = 0;
int minSumm = 0;

for (int i = 0; i < mass.GetLength(0); i++)
{
    int tempSumm = 0;
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        tempSumm += mass[i, j];
    }
    Console.WriteLine(tempSumm);
    if (i == 0)
    {
        minSumm = tempSumm;
    }
    else
    {
        if (minSumm > tempSumm)
        {
            minSumm = tempSumm;
            lineWithMinSumm = i;
        }
    }
}
Console.WriteLine($"Строка с наименьшей суммой элементов с индексом { lineWithMinSumm} и равна {minSumm}");