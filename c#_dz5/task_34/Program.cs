/*
Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2
*/
Console.WriteLine("Введите длину массива");

int number = Int32.Parse(Console.ReadLine());

int[] array = new int[number];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
int evenCol = 0;
PrintArray(array);
for (int i = 0; i < array.Length; i++)
{
    if ( array[i] %2 ==0) evenCol++;
}
Console.WriteLine($"Из них четных {evenCol}");