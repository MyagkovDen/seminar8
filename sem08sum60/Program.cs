/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

Console.Clear();

int[,,] array = GetArray(3, 3, 3, 10, 100);
PrintArray(array);

int[,,] GetArray(int x, int y, int z, int minValue, int maxValue)
{
    int[,,] arr = new int[x, y, z];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                int temp = new Random().Next(10, 100);
                bool notExist = VerifyNumber(arr, temp);
                if (notExist) arr[i, j, k] = temp;
                else k--;
            }
        }
    }
    return arr;
}

bool VerifyNumber(int[,,] arr, int numeral)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (arr[i, j, k] == numeral) return false;
            }
        }
    }
    return true;
}


void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.WriteLine($"{arr[i, j, k]} ({i}, {j}, {k})");
            }
        }
    }
}