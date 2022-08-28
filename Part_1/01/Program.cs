// 1. По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Please, put the first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, put the second number");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b*b)
{
    Console.WriteLine ("It is the square");
}
else
{
    Console.WriteLine ("It is not the square");
}