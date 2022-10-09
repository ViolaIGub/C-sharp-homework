// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
//в каждом столбце.
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
int count1 = (matrix [0,0]+matrix [1,0]+matrix [2,0])/matrix.GetLength(1);
int count2 = (matrix [0,1]+matrix [1,1]+matrix [2,1])/matrix.GetLength(1);
int count3 = (matrix [0,2]+matrix [1,2]+matrix [2,2])/matrix.GetLength(1);
int count4 = (matrix [0,3]+matrix [1,3]+matrix [2,3])/matrix.GetLength(1);
Console.WriteLine(count1);
Console.WriteLine(count2);
Console.WriteLine(count3);
Console.WriteLine(count4);      
