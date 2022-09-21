// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

using System;

int a, b, d;

Console.Write("Введите первое число из трехзначного числа:");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число из трехзначного числа:");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число из трехзначного числа:");
d = Convert.ToInt32(Console.ReadLine());

if(a == d)
{
    Console.WriteLine("Число - палиндром");
}
else 
{
    Console.WriteLine("Число - не палиндром");
}
