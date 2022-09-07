// 26. Возведите число А в натуральную степень B используя цикл
int Multiple(int a, int b)
{
    int result = a;
    for (int i = 2; i<=b; i++)
    {
       result*=a;
    }
return result;
}
Console.WriteLine("Please write a number");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please write a second number");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Multiple(n,m));