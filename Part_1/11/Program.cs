// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int a = new Random().Next(10,100);
Console.WriteLine(a);
if (a%10>a/10)
{
    Console.WriteLine(a%10);
}
else
{
    Console.WriteLine(a/10);
}