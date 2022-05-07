/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

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