// Задача 59: В прямоугольной матрице найти строку с наименьшей суммой элементов.

int[,] massiv = new int[5, 2];
void fillArray(int[,] filled)
{
    for (int i = 0; i < filled.GetLength(0); i++)
    {
        for (int j = 0; j < filled.GetLength(1); j++)
        {
            filled[i, j] = new Random().Next(-10, 10);
        }
    }
}


fillArray(massiv);
void Finder(int[,] finded)
{
    int min = 0;
    int minIndex=0;

    for (int i = 0; i < finded.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < finded.GetLength(1); j++)
        {
            if (i == 0)
            {
                sum = finded[i, j] + sum;
                min = sum;
                minIndex=i;
            }
            else sum = finded[i, j] + sum;

        }
        if (min >sum ){
            min=sum;
            minIndex=i;
        }
        

        //Console.WriteLine(min);
    }
    Console.WriteLine($"the lowest index is {minIndex} summ {min} ");
}
Finder(massiv);
void printArray(int[,] printed)
{
    for (int i = 0; i < printed.GetLength(0); i++)
    {
        for (int j = 0; j < printed.GetLength(1); j++)
        {
            Console.Write(printed[i, j] + " ");
        }
        Console.WriteLine();
    }
}
printArray(massiv);