// 49. Показать двумерный массив размером m×n заполненный вещественными числами
void Print(double[,] array)
{
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write("{0,6:F2}",array[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double [,] MassNum(int row, int column, double from , double  to)
{
    double[,] array = new double [row, column];
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = Math.Round(from + rand.NextDouble() * (to - from), 2);
        } 
    }
    return array;
}

double [,] matrix = MassNum(4,4,0,10);
Print(matrix);