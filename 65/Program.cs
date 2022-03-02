//Задача 65: Спирально заполнить двумерный массив:

int[,] array = new int[4, 4];
int s = 1;


for (int j = 0; j < array.GetLength(1); j++)
{
    array[0, j] = s;
    s++;
}

for (int i = 1; i < array.GetLength(0); i++)
{

    array[i, 3] = s;
    s++;
}
for (int i = 2; i > -1; i--)
{
    array[3, i] = s;
    s++;
}
for (int i = 2; i > 0; i--)
{
    array[i, 0] = s;
    s++;
}

int c = 1;
int d = 1;

while (s < 4 * 4)
{
    while (array[c, d + 1] == 0)
    {
        array[c, d] = s;
        s++;
        d++;
    }
    while (array[c + 1, d] == 0)
    {
        array[c, d] = s;
        s++;
        c++;
    }
    while (array[c , d ] == 0)
    {
        array[c, d] = s;
        s++;
        d--;

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