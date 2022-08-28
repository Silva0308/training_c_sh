// 4. Найти максимальное из трех чисел
int MaxNumber(int a, int b, int c)
{
    int max = a;
    if (b > max)
    {
        max = b;
        if (c > max)
        {
            max = c;
        }
    }
    else
    {
        if (c > max)
        {
            max = c;
        }
    }
    return max;
}
int num = MaxNumber(8, 10, 6);
Console.WriteLine($"max={num}");
