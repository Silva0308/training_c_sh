// 28. Подсчитать сумму цифр в числе
int SumNum (int n)
{
    int result = 0;
    string SomeNumberText = Convert.ToString(n);
    for (int i = 0; i <= SomeNumberText.Length; i++)
    {
        result += n%10;
        n/=10;
    }
    return result;
}
Console.WriteLine(SumNum(12711));