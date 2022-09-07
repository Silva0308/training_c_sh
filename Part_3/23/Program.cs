// 23. Показать таблицу квадратов чисел от 1 до N 
void Squares (int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(i*i);
    }
}
Console.WriteLine("Please write a number");
int n = Convert.ToInt32(Console.ReadLine());
Squares (n);