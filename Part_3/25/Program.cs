// 25. Найти сумму чисел от 1 до А
int Factorial(int n)
{
    if (n == 0 || n == 1)
    {
        return 1;
    }
    else
    {
        int factorial = 0;
        for (int i = 1; i <= n; i++)
        {
            factorial += i;
        }
        return factorial;
    }
}
Console.WriteLine("Please write a number");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Factorial(n));