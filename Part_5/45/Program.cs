// 45. Показать числа Фибоначчи
int[] FibonacciNum(int n)
{
    int[] array = new int[n];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < n; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
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

int [] fib = FibonacciNum (8);
Print (fib);
