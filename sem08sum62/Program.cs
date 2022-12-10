/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

Console.Clear();

int[,] array = GetArray(4, 4);
PrintArray(array);
Console.WriteLine();


int[,] GetArray(int rows, int columns)
{
    int[,] arr = new int[rows, columns];

    int temp = 1;
    int rowStart = 0;
    int columnStart = 0;
    int rowEnd = arr.GetLength(0) - 1;
    int columnEnd = arr.GetLength(1) - 1;
    int i, j;

    while (temp <= rows * columns)
    {
        i = rowStart;
        for (j = columnStart; j < columnEnd + 1; j++)
        {
            arr[i, j] = temp++;
        }
        rowStart++;

        j = columnEnd;
        for (i = rowStart; i < rowEnd + 1; i++)
        {
            arr[i, j] = temp++;
        }
        columnEnd--;

        i = rowEnd;
        for (j = columnEnd; j >= columnStart; j--)
        {
            arr[i, j] = temp++;
        }
        rowEnd--;

        j = columnStart;
        for (i = rowEnd; i > columnStart; i--)
        {
            arr[i, j] = temp++;
        }
        columnStart++;
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}