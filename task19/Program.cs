// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

using System;

int a, b, d, e, f;

Console.Write("Введите первое число из пятизначного числа:");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число из пятизначного числа:");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число из пятизначного числа:");
d = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите четвертое число из пятизначного числа:");
e = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите пятое число из пятизначного числа:");
f = Convert.ToInt32(Console.ReadLine());

if(a == f || b == e)
{
    Console.WriteLine("Число - палиндром");
}
else 
{
    Console.WriteLine("Число - не палиндром");
}
