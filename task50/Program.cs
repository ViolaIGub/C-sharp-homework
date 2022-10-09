// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
using System;

int [,] matrix = new int [3,4];
matrix [0,0] = 1;
matrix [0,1] = 4;
matrix [0,2] = 7;
matrix [0,3] = 2;
matrix [1,0] = 5;
matrix [2,0] = 8;
matrix [1,1] = 9;
matrix [1,2] = 2;
matrix [1,3] = 3;
matrix [2,1] = 4;
matrix [2,2] = 2;
matrix [2,3] = 4;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]}");
    }
Console.WriteLine();
}
int a;
Console.Write("Введите любое число");
Console.WriteLine();
a = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix [i,j] == a)
        {
        Console.WriteLine(matrix[i,j]);
        }       
    } 
}
Console.WriteLine("такого элемента не существует"); 
 