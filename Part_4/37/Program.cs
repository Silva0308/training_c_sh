// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
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

void NumCount (int [] array)
{
    int count=0;
    foreach (int item in array)
    {
        if (item >= 10 && item <=99)
        {
            count ++;
        }
    }
  Console.WriteLine($"Quontity of numbers from [10,99] ia {count}");  
}
int [] newArray = FillArray (123, 0, 120);
PrintArray (newArray);
NumCount(newArray);