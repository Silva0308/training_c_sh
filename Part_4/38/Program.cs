// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
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
 int SumOdd (int [] array)
 {
    int sum = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        sum+= array[i];
    }
    return sum;
 }

 int [] newArray = FillArray (8, -9, 10);
PrintArray (newArray);
Console.WriteLine(SumOdd(newArray));