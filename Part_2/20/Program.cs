// 20. Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Please write the quarter number");
int quarter = Convert.ToInt32(Console.ReadLine());
if (quarter < 1 || quarter > 4)  Console.WriteLine("It is not a quarter number");
else if (quarter == 1) Console.WriteLine("x<0, y >0");
else if (quarter == 2)  Console.WriteLine("x>0, y >0");
else if (quarter == 3)  Console.WriteLine("x<0, y <0");
else Console.WriteLine("x>0, y <0");
