// 41. Выяснить являются ли три числа сторонами треугольника 
void Triagle(int a, int b, int c)
{
    if (a+b>c && a+c>b&& b+c>a) Console.WriteLine ("It is a triangle");
    
    else Console.WriteLine ("It is NOT a triangle");
}
Triagle(10,4,5);