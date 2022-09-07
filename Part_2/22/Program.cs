// 22. Найти расстояние между точками в пространстве 2D/3D
void Distance2D (double x1,double y1, double x2, double y2)
{
double distance= Math.Round(Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)),2);
Console.WriteLine ($"Distanse is {distance}");
}

double Distanse3D (double x1,double y1, double z1, double x2, double y2, double z2)
{
    return Math.Round(Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2)),2);
}
Console.WriteLine("Please put x1:");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please put y1:");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please put z1:");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please put x2:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please put y2:");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please put z2:");
double z2 = Convert.ToDouble(Console.ReadLine());
Distance2D (x1,y1,x2,y2);
Console.WriteLine ($"3D distancs is {Distanse3D(x1,y1,z1,x2,y2,z2)}");