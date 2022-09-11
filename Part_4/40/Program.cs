// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double [] FillArray (int n, double min, double max)
{ 
    double [] array = new double [n];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = Math.Round(min + rand.NextDouble() * (max - min), 2);
    }
    return array;
}
void PrintArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array[i]}, ");
    }
    Console.WriteLine();
}

double DifMinMax (double [] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
            min = array[i];
        if (max < array[i])
            max = array[i];
   }
    Console.WriteLine("max = {0}", max);
    Console.WriteLine("min = {0}", min);
    double result = Math.Round(max-min,2);
    return result;
}


double [] newArray = FillArray (8, 0, 10);
PrintArray (newArray);
double diff = DifMinMax(newArray);
Console.WriteLine (diff);