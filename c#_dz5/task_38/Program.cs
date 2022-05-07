/*
Задача 38: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива.
[3 7 22 2 78] -> 76
*/

Console.WriteLine("Введите длину массива");

int number = Int32.Parse(Console.ReadLine());


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] array = new int[number];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
}
PrintArray(array);

int min = array[1];
int max = array[1];
for (int i = 0; i < array.Length; i++)
{
    if ( min > array[i] ) min = array[i];
    if ( max < array[i] ) max = array[i];
}
Console.WriteLine($"min={min} max={max}  Ответ={min*max}");