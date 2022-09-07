// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Please write some number");
string n = Convert.ToString(Console.ReadLine());
if (n.Length>=3)
{
    Console.WriteLine($"The third digit of this number is {n [2]}");
}
else
{
    Console.WriteLine("There is no the third digit");
}