// 3. По заданному номеру дня недели вывести его названиe
string[] Days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

Console.WriteLine("Enter day number");
int a =int.Parse(Console.ReadLine());

if (a<1 || a>7)
{
    Console.WriteLine("Wrong number");
}
else
{
    Console.WriteLine(Days [a-1]);
}