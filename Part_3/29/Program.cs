// 29. Написать программу вычисления произведения чисел от 1 до N
int Factorial (int n)
{
int result = 1;
for (int i = 1; i <=n; i++)
{
    result *=i;
}
return result;
}
Console.WriteLine(Factorial(5));