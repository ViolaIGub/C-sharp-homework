// задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
using System;

string NumbersFor (int a, int b)
{
string result = String.Empty;
for (int i=a; i>=b; i--)
{
    result += $"{i }";
}
return result;
}
string NumbersRec (int a, int b)
{
    if (a<=b) return NumbersRec (a+1, b) + $"{a }";
    else return String.Empty;
}
Console.WriteLine(NumbersFor(1,8));
Console.WriteLine(NumbersRec(1,8));