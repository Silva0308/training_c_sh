// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

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
}

int [] newArray = FillArray (8, 0, 2);
PrintArray (newArray);