// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
using System;

int a, b, c;//, d;
int sum = 0;

Console.Write("Введите любое натуральное число А");
Console.WriteLine();
a = Convert.ToInt32(Console.ReadLine());

b = (a % 10);
c = ((a % 100) - b)/10;
//d = ((a - (a % 100))/100); 
sum = b + c;// + d;

Console.WriteLine("Сумма чисел в числе А равна " + sum);
