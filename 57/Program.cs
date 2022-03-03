//Задача 57: Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

int[,] array = new int[5, 5];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(-10, 10);
    }
    
}



for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < array.GetLength(0); i++)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int n = j + 1; n < array.GetLength(1); n++)

            if (array[i, n] > array[i, j ])
            {
                int tmp = array[i, j];
                array[i, j] = array[i, n ];
                array[i, n ] = tmp;
            }
        // Console.Write(array[i, j] + " ");
    }
}
Console.WriteLine();


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

