// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
using System;
int n=15;
int SumFor(int n);
{
    int result =0;
    for (int i=1; i <= n; i++) result +=i;
    return result;
}
int SumRec(int n);
{
    if (n == 1) return 1;
    else return n + SumRec(n-1);
}
Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));
