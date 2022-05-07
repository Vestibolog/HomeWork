/*
Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int numberA = 3;
int numberB = 5;
int result = 1;
for (int i = 0; i < numberB; i++)
{
    result *= numberA;
}
Console.WriteLine($"{numberA} в степерни {numberB} = {result}");
Console.WriteLine($"или так {Math.Pow(numberA, numberB)}");