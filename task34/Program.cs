// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
using System;

void FillArray(int [] collection);
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection [index] = new Random().Next(100, 999);
        index++;
    }
}

void PrintArray(int [] col);
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int array = new int[10];

FillArray(array);
PrintArray(array);
