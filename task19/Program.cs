// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

using System;

int n, reversed = 0, remainder, original;

Console.Write("Введите целое число:");
n = Convert.ToInt64(Console.ReadLine());
original = n;

while( n != 0 )
{
    remainder = n % 10;
    reversed = reversed * 10 + remainder;
    n = 10;
}

if(original == reversed)
{
    Console.WriteLine(original + " палиндром");
}
else 
{
    Console.WriteLine(original + " не палиндром");
}
