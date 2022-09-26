// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// x=(b2-b1)/(k1-k2) , 
// y=k1(b2-b1)/(k1-k2)+b1

using System;

double b1 = 2, k1 = 5, b2 = 4, k2 = 9;
double x, y;

x=(b2-b1)/(k1-k2);
y= k1*(b2-b1)/(k1-k2)+b1;

Console.WriteLine(x);
Console.WriteLine(y);