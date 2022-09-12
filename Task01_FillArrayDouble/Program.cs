﻿// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. m = 3, n = 4.
// 0,5  7       -2      -0,2
// 1    -3,3    8       -9,9
// 8    7,8     -7,1    9

int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

double [,] array = new double [rows,columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i,j] = Math.Round(new Random().NextDouble()+new Random ().Next(-10,10),2);
        Console.Write(array[i,j]+"\t");
    }
    Console.WriteLine();
}
