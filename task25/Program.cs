// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
using System;

int a, b;
int i;
int composition = 0;
int count = 0;

Console.Write("Введите любое натуральное число А");
Console.WriteLine();
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите любое натуральное число В");
Console.WriteLine();
b = Convert.ToInt32(Console.ReadLine());

for (i = 0; i < b+1; i++)
{
    composition = 1;
    count = i;
    while(count > 0)
    {
        composition *= a;
        count --;
}
}
Console.WriteLine("Число " + a + " в степени " + b + " равно " + composition);