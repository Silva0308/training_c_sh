// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. 
// Найти сумму положительных/отрицательных элементов массива
int [] FillArray (int n, int min, int max)
{ 
    int [] array = new int [n];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(min,max);
    }
    return array;
}
void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array[i]}, ");
    }
    Console.WriteLine();
}

int SumArray (int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >0)
        {
            result += array[i];
        }
    }
    return result;
}

int [] newArray = FillArray (12, -9, 10);
PrintArray (newArray);
Console.WriteLine ($"Sum of positive elements is {SumArray(newArray)}");