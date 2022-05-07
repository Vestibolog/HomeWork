/*
Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
Console.WriteLine("Введите длину массива");

int number = Int32.Parse( Console.ReadLine() );

int[] array = new int[number];
for (int i=0; i < array.Length; i++)
{
    Console.WriteLine($"Введите число {i+1}");
    array[i] = Int32.Parse( Console.ReadLine() );
}

for (int i=0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}