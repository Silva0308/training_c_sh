// 48. Показать двумерный массив размером m×n заполненный целыми числами
int [,] FillArray (int n, int m, int min, int max)
{
    int [,] matrix = new int [n,m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(min,max);
        }
    }
    return matrix;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int [,] array =FillArray(4,4,1,10);
PrintArray(array);