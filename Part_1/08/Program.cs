// 8. Показать четные числа от 1 до N

Console.WriteLine("Please write a number");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i<=n; i+=2)
{
    Console.Write($"{i}, ");
}