// 43. Написать программу преобразования десятичного числа в двоичное
void DiNum (int num)
{ 
	string result = String.Empty;
while (num != 0)
{ 
    result=num%2+result;
    num/=2;
} 
Console.WriteLine(result);
}
DiNum(75);