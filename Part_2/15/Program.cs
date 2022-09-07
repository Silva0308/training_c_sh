//15. Дано число. Проверить кратно ли оно 7 и 23
Console.WriteLine("Please write a number");
int n = Convert.ToInt32(Console.ReadLine());
if (n%7 == 0 && n%23== 0 )
{
    Console.WriteLine ($"{n} is multiples of 7 and 23");
}
else
{
    Console.WriteLine ($"{n} is not multiples of 7 and 23");
}