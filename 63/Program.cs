﻿// Задача 63: Сформировать трёхмерный массив с не повторяющимися двузначными числами и вывести его на экран построчно, с индексами элементов.
int[,,] array = new int[3, 4, 5];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int n = 0; n < array.GetLength(1); n++)
    {
        for (int j = 0; j < array.GetLength(2); j++)
        {
            array[i, n, j] = new Random().Next(1, 10);
        }
        Console.WriteLine();
    }
}



for (int i = 0; i < array.GetLength(0); i++)
{
    for (int n = 0; n < array.GetLength(1); n++)
    {
        for (int j = 0; j < array.GetLength(2); j++)
        {
            Console.Write(array[i, n, j] + " ");
        }
        Console.WriteLine();
    }
     Console.WriteLine();
}