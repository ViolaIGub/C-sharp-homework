// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
using System;

int [] array =  {1, 2, 5, 7, 19, 6, 1, 33};
int index; 
int n = array.Length;
index = 0;
n = 8;

while (index < n)
{
    Console.WriteLine("Значение " + index + " -го элемента массива: " + array [index]);
index++;
}
