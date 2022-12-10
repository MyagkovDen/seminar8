/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.Clear();

int[,] array = GetArray(4, 3, 1, 10);
PrintArray(array);
Console.WriteLine();
GetMinSumInRow(array);


void GetMinSumInRow(int[,] arr)
{
    int[] collection = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        collection[i] = sum;
    }

    int min = collection[0];
    int iMin = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] < min)
        {
            min = collection[i];
            iMin = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {iMin + 1}  строка");
}

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue);
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