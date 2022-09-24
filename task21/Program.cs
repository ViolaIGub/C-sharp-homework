// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

using System;
double x1 = 7, x2 = 1, y1 = -5, y2 = -1, z1 = 0, z2 = 9;
double [] array1 = {x1, y1, z1}, array2 = {x2, y2, z2};
double destination;
double square = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1);

destination = Math.Sqrt(square);

Console.WriteLine("Расстояние между точками равно " + destination);
