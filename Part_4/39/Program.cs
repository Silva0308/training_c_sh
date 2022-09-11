// 39. Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
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
void ArrayMult(int [] array)
{
if (array.Length%2==0)
{
for (int i = 0; i < array.Length/2; i++)
{
    Console.WriteLine (array[i]*array[array.Length-1-i]);
}
}
else
{
    for (int i = 0; i < array.Length/2; i++)
{
    Console.WriteLine (array[i]*array[array.Length-1-i]);
}
 Console.WriteLine (array[array.Length/2]);
}
}
 int [] newArray = FillArray (9, -9, 10);
PrintArray (newArray);
ArrayMult (newArray);