// 34. Написать программу замену элементов массива на противоположные
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

int [] ArrayInversion (int [] array)
{
    for (int i = 0; i <array.Length; i++)
    {
        array[i]*=-1;
    }
return array;
}

int [] newArray = FillArray (8, -9, 10);
PrintArray (newArray);
int [] invArray = ArrayInversion (newArray);
PrintArray (invArray);