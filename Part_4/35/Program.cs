// 35. Определить, присутствует ли в заданном массиве, некоторое число 
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
bool IsNum (int [] array, int n)
{
    bool flag = false;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == n)
    {
        flag = true;
        Console.WriteLine($"There is number {n} in array.");
        return flag;
    }
}
    if (flag== false)
    {
        Console.WriteLine($"There is no number {n} in array.");
        return flag;
    }
return flag;
}
int [] newArray = FillArray (8, -9, 10);
PrintArray (newArray);
Console.WriteLine(IsNum (newArray, 5));