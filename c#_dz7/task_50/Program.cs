/*
Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] mass = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};
Console.WriteLine("Введите позиции элемента по строке");
int positionsLine = int.Parse(Console.ReadLine());
Console.WriteLine("Введите позиции элемента по столбцу");
int positionsСolumn = int.Parse(Console.ReadLine());

if ((positionsLine < mass.GetLength(0)) & (positionsСolumn < mass.GetLength(1)))
{
    Console.WriteLine($"Элемента с позицией {positionsLine} {positionsСolumn} равен {mass[positionsLine, positionsСolumn]}");
}
else
{
    Console.WriteLine($"Элемента с позицией {positionsLine} {positionsСolumn} нет");
}


