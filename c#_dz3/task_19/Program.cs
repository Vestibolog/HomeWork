//--------------------task 19-------------------
int number = 23432;

int number_1 = number/10000;
int number_2 = number/1000 % 10;
int number_4 = (number % 100)/10;
int number_5 = number % 10;

Console.WriteLine($"Число =  {number} = {number_1} {number_2} _ {number_4} {number_5}");
if ( (number_1 == number_5) & (number_2 == number_4) )
{
    Console.WriteLine($"Число =  {number} палиндромом");
}else
{
    Console.WriteLine($"Число =  {number} НЕ палиндромом");
}
//--------------------task 21-------------------
int pointA_x = 7;
int pointA_y = -5;
int pointA_z = 0;

int pointB_x = 1;
int pointB_y = -1;
int pointB_z = 9;

double result = Math.Sqrt(Math.Pow(pointA_x - pointB_x, 2) +
                           Math.Pow(pointA_y - pointB_y, 2) +
                           Math.Pow(pointA_z - pointB_z, 2));
Console.WriteLine($"Ответ = {Math.Round(result, 2)}");
//--------------------task 23-------------------
int iterator = 5;
Console.WriteLine($"Итератор = {iterator}");
for ( int i = 1; i <= iterator; i++ )
{
    Console.Write($" {Math.Pow(i,3)}, ");
}
Console.WriteLine("");