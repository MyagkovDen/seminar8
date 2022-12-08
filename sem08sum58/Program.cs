/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.Clear();

int[,] array = GetArray(3, 3, 0, 5);
int[,] matrix = GetArray(3, 3, 6, 10);
PrintArray(array);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
int[,] result = ProductMatrixes(array, matrix);
PrintArray(result);

int[,] ProductMatrixes(int[,] arr, int[,] matr)
{
    int[,] res = new int[arr.GetLength(0), arr.GetLength(1)];
    int k = 0;
    int l = 0; 
    int m = 0;
    int product = 1;
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                do
                {
                    product = arr[i, j] * matr[m, n];
                    sum += product;
                    m++;
                }
                while (m < 0);
            }
            res[k, l] = sum;
            l++;
            m = 0;
            sum = 0;
        }
        k++;
        l = 0;
    }
    return res;
}

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Random rnd = new Random();
            arr[i, j] = rnd.Next(minValue, maxValue);
        }
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