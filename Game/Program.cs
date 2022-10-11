// 1) Самостоятельно сделать меню выбора уровня, так же как и само меню
//2) Добавить еще больше уровней
using System;

string[,] matrix = {{" "," "," "," "," ",},
                    {" "," "," "," "," ",},
                    {" "," ","@"," "," ",},
                    {" "," "," "," "," ",},
                    {" "," "," "," "," ",},
                    {" "," "," "," "," ",}};


    for (int i=0; i < matrix.GetLength(0); i++)
    {
        for (int j=0; j < matrix.GetLength(1); j++)
        {
            Console.WriteLine(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }

int x = 2;
int y = 2;
while(true)
{
    Console.Clear();
    matrix[y,x] = " ";
    ConsoleKeyInfo User_keyTab = Console.ReadKey();
    if (User_keyTab.Key == ConsoleKey.W) y--;
    if (User_keyTab.Key == ConsoleKey.S) y++;
    if (User_keyTab.Key == ConsoleKey.A) x--;
    if (User_keyTab.Key == ConsoleKey.D) x++;

    if (y >= matrix.GetLength(0)) y = matrix.GetLength(0)-1;
    if (y <=0) y=0;
    if (x >= matrix.GetLength(1)) y = matrix.GetLength(1)-1;
    if (x <=0) x=0;
    matrix[y,x] = "@";
}
