// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Please write the first number");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please write the second number");
int m = Convert.ToInt32(Console.ReadLine());
if (n%m == 0)
{
    Console.WriteLine ($"{n} is multiples of {m}");
}
else
{
    Console.WriteLine ($"the remainder of the division is {n%m}");
}