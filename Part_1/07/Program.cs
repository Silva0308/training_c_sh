// 7. Показать числа от -N до N

Console.WriteLine("Please write a number");
int n = Convert.ToInt32(Console.ReadLine());
if (n>0)
{
    int a = n*-1;
    while (a<=n)
    {
        Console.Write ($"{a}; ");
        a++;
    }
}
if (n == 0)
{
    Console.WriteLine ("0");
}
else
{
    int b = n*-1;
     while (b>=n)
     {
        Console.Write ($"{b}; ");
        b--;
     }
}
