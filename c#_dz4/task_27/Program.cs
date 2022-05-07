/*
Задача 27: Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int number = 9012;
int result = 0;
while ( number != 0)
{
    int currentNum = number % 10;
    result += currentNum;
    Console.WriteLine(currentNum);
    number /= 10;
}
Console.WriteLine($"Сумама = {result}");