// 2. Даны два числа. Показать большее и меньшее число
Console.WriteLine("Please write the first number");
int a =int.Parse(Console.ReadLine());
Console.WriteLine("Please write the second number");
int b =int.Parse(Console.ReadLine());
if (a==b)
{
    Console.WriteLine("This numbres are equal");
}
else if (a>b)
{
    Console.WriteLine($"{a}>{b}");
}
else
{
    Console.WriteLine($"{a}<{b}");
}