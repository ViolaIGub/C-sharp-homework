// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
using System;

void FillArray(int [] collection);
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection [index] = new Random().Next();
        index++;
    }
}

int count = col.Length;
int position = 0;
int sum = 0;

while(position < count)
{
    if(position %2 != 0)
    sum = sum + col [position];
    position++;
}

int array = new int[5];

Console.WriteLine(sum);
