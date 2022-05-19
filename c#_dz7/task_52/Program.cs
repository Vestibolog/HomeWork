/*
Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого
столбца: 4,6; 5,6; 3,6; 3.
*/

int m = 3;
int n = 4;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(-10, 10);
    }
}
/*
mass = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};
*/
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

for (int j = 0; j < mass.GetLength(1); j++)
{
    double tempInt = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        tempInt += mass[i, j];
    }
    tempInt = tempInt / mass.GetLength(0);
    Console.Write($"{Math.Round(tempInt,1)} ");
}