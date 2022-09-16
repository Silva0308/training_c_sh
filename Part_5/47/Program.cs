// 47. Написать программу копирования массива
int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}
void Print(int[] arr) 
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
 int [] CopyArray (int [] array)
 {
    int [] result = new int [array.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i]= array[i];
    }
    return result;
 }

 int [] array1 = MassNums(5,1,10);
 Print(array1);
 int [] array2 =CopyArray(array1);
 Print (array2);