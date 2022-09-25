// Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
using System;

double array[] = {5, 6, 7, 9, 4, 2, 7, 2, 4};
double max = Max(
    Max(array[0], array[1],array[2]),
    Max(array[3], array[4],array[5]),
    Max(array[6], array[7],array[8]),
);
Console.WriteLine(max);

double min = Min(
    Min(array[0], array[1],array[2]),
    Min(array[3], array[4],array[5]),
    Min(array[6], array[7],array[8]),
);
Console.WriteLine(min);

Console.WriteLine(max - min);
