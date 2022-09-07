// 17. По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Please write the first number");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please write the second number");
int m = Convert.ToInt32(Console.ReadLine());
if (n/m == m)
{
    Console.WriteLine($"{n} is the square of the {m}");
}
else if (m/n == n)
{
    Console.WriteLine($"{m} is the square of the {n}");
}
else
{
    Console.WriteLine("This numbers are not squares");
}