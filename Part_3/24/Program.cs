// 24. Найти кубы чисел от 1 до N
void Cubes(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine (Math.Pow(i,3));
    }
}
Console.WriteLine("Please write a number");
int n = Convert.ToInt32(Console.ReadLine());
Cubes (n);