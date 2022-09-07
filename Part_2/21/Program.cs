// 21. Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Please put 5 digit number");
int n =Convert.ToInt32(Console.ReadLine());
if (n/10000 == n%10 && (n/1000)%10 == (n%100)/10) Console.WriteLine("It is a palindrome");
else Console.WriteLine("It is NOT a palindrome");

//второй способ
Console.WriteLine("Please put number/word");
string number = Console.ReadLine();
int length = number.Length;
string txtToCheck = number.Replace(" ","");  /// для проверки текста на палиндром

bool IsPalindrome()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}
if (IsPalindrome()) Console.WriteLine($"Number/word- {number} - is palindrome");
else Console.WriteLine($" {number} is not a palindrome");
