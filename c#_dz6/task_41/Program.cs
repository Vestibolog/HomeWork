/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите числа через пробел");
string str = Console.ReadLine();
string[] strArray = str.Split(" ");
int[] array = new int[strArray.Length];
int result = 0;

for (int i = 0; i < strArray.Length; i++)
{
    int tempInt = int.Parse(strArray[i]);
    array[i] = tempInt;
    if (tempInt < 0) result++;
}
PrintArray(array);
Console.WriteLine($"Отрицательных чисел {result}");

