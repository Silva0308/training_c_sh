// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
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
void EvenOdd( int [] array)
{
    int countEven =0;
    int countOdd =0;
    foreach (int item in array)
    {
        if (item%2 ==0)
        {
            countEven ++;
        }
        else
        {
            countOdd ++;
        }
    }
    Console.WriteLine ($"Even numbers - {countEven}");
    Console.WriteLine ($"Odd  numbers - {countOdd}");
}
int [] newArray = FillArray (8, 100, 1000);
PrintArray (newArray);
EvenOdd(newArray);