﻿/*
Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int[] array = {-4, -6, 89, 6 };
int result = 0;
if ( array.Length > 1)
{
    for (int i=1; i < array.Length; i +=2)
    {
        result += array[i];
    }
}
Console.WriteLine($"Ответ = {result}");