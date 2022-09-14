// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. m = 3, n = 4.
Console.WriteLine("Задайте количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] array = new double [rows,columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i,j] = array[i,j] = new Random().Next(-100,101)/10.0;
        Console.Write(Math.Round(array[i,j],1) +"\t");
    }
    Console.WriteLine();
}