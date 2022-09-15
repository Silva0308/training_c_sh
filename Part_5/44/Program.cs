// 44. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
void LinesIntersection(double b1, double k1, double b2, double k2)
{
    if (k1 == 0 && k1 == -0)
    {
        Console.WriteLine("Palrallel lines");
    }
    else
    {
        double x = Math.Round((b2 - b1) / (k1 - k2), 2);
        double y = k1 * x + b1;
        Console.WriteLine($"The point of intersection is ({x},{y})");
    }

}
LinesIntersection(2,1,1,2);