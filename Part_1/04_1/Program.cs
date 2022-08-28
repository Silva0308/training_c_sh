// 4. Найти максимальное из трех чисел
int MaxNumber(int a, int b, int c)
{
    int [] num = {a,b,c};
    int max = num [0];
    for (int i = 1; i < num.Length; i++)
    {
        if (num[i] > max)
        {
            max = num [i];
        }
    }
    return max;
}
int num = MaxNumber(24, 10, 34);
Console.WriteLine($"max={num}");
