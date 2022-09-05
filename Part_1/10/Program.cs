// 10. Показать вторую цифру трёхзначного числа
Console.WriteLine("Please write a three-digit number");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((n%100-n%10)/10);
