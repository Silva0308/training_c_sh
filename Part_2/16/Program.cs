// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Please write a day number!");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 7 || day < 1)
{
    Console.WriteLine("Error");
}
else if (day ==6 || day == 7)
{
    Console.WriteLine("It is a weekend");
}
else
{
    Console.WriteLine("It is a working day");
}