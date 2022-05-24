/*
Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.
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

for (int i = 0; i < mass.GetLength(0); i++)
{
    int[] tempArray = new int[mass.GetLength(1)];
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        tempArray[j] = mass[i, j];
    }
    Array.Sort(tempArray);
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = tempArray[j];
    }
}

PrintArray(mass);