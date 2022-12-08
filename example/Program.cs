Console.Clear();

int[,] array = new int[5, 5];


int i = 0;
int j = 0;
int n = array.GetLength (0);
int m = array.GetLength (1);
Console.WriteLine($"{n} ");
Console.WriteLine($"{m} ");
array [i,j] = 1;
int num = 2;
for (int k = 1; k < m; k++)
{
array[i,k] = num;
num++;
}
PrintArray(array);







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
