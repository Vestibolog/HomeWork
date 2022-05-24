/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц.
*/
int m = 2;
int n = 2;

int[,] FillArray(int m, int n)
{
    int[,] tempArray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            tempArray[i, j] = new Random().Next(0, 10);
        }
    }
    return tempArray;
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

//int[,] massOne = FillArray(m, n);
int[,] massOne = new int[,]
{
    {5,-4,12},
    {8,2,6},
    {11,7,10},
};
PrintArray(massOne);
Console.WriteLine();

//int[,] massTwo = FillArray(m, n);
int[,] massTwo = new int[,]
{
    {2},
    {-5},
    {9},
};
PrintArray(massTwo);
Console.WriteLine();

int[,] productTwoMatrices = new int[massOne.GetLength(0), massTwo.GetLength(1)];

if (massOne.GetLength(1) != massTwo.GetLength(0))
{
    Console.WriteLine("Перемножение невозможно");
}
else
{
    int arrayIndex = massOne.GetLength(1);
    Console.WriteLine($"Индекс матрицы {arrayIndex}");
    for (int i = 0; i < massOne.GetLength(0); i++)
    {
        for (int j = 0; j < massTwo.GetLength(1); j++)
        {
            int tempNum = 0;
            for (int k = 0; k < arrayIndex; k++)
            {
                tempNum += massOne[i, k] * massTwo[k, j];
            }
            productTwoMatrices[i, j] = tempNum;
        }
    }
}
PrintArray(productTwoMatrices);






