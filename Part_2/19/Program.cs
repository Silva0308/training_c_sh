// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Please put x:");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please put y:");
double y = Convert.ToDouble(Console.ReadLine());
if (x == 0 || y == 0)
{
    Console.WriteLine("It is not a quarter");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("It is I quarter");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("It is II quarter");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("It is III quarter");
}
else
{
    Console.WriteLine("It is IV quarter");
}
