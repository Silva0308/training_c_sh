// 42. Определить сколько чисел больше 0 введено с клавиатуры
Console.WriteLine ("Please, write some numbers");
var numbers = Console.ReadLine()
        .Split(new[] {" "},StringSplitOptions.RemoveEmptyEntries)
        .Select(Int32.Parse);
int count =0;
foreach(var n in numbers)
  if (n>0)
  {
    count++;
  }
  Console.WriteLine($"You wrote {count} positive numbers");
