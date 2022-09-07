// 27. Определить количество цифр в числе
void NumberLenght (string n)
{
Console.WriteLine(n.Length);
}
Console.WriteLine("Please write a number");
string SomeNumberText = Convert.ToString(Console.ReadLine());
NumberLenght (SomeNumberText);