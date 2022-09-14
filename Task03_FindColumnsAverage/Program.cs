// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] array = new int [5,4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1,11);
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Среднее арифметическое: ");

for (int j = 0; j < array.GetLength(1); j++)
{
    double average = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        average = average + array[i,j];
    }
    Console.Write(Math.Round(average/array.GetLength(0),2) + "\t");
}