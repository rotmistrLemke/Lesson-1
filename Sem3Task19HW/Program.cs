/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
* Сделать вариант через СЛОВАРЬ четырехзначных палиндромов */


//Чтение данных консоли
int ReadData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

// Заполнение словаря
Dictionary<int, string> DictionaryAdd()
{
    //Объвление словаря
    Dictionary<int, string> palindrome = new Dictionary<int, string>();
    //Объявление счетчика для ключа словаря
    int id = 0;
    for (int number = 1000; number < 10000; number++)
    {
        //сравнение первого с последним символа и второго с третьим
        char[] digits = number.ToString().ToCharArray();
        if (digits[0] == digits[3] && digits[1] == digits[2])
        {
            palindrome[id] = number.ToString();
            id++;
        }
    }
    return palindrome;
}

// Проверка на палиндром
bool PalindromeCheck(int number)
{
    char[] digits = number.ToString().ToCharArray();
    string res = digits[0].ToString() + digits[1].ToString() + digits[3].ToString() + digits[4].ToString();
    if (DictionaryAdd().ContainsValue(res.ToString()))
    {
        return true;
    }
    else
    {
        return false;
    }
}
/* 
// Проверка, что находиться в словаре

for (int i = 0; i < DictionaryAdd().Count; i++)
    Console.Write(DictionaryAdd()[i] + ",");
 */

int num = ReadData("Введите пятизначное число для проверки: ");

if (num < 10000 || num > 99999)
{
    Console.WriteLine("Хорошая попытка, кожанный мешок, но меня не провешь, попробуй снова");
}
else
{
    if (PalindromeCheck(num))
    {
        Console.WriteLine("Это палиндром");
    }
    else
    {
        Console.WriteLine("Увы, это не палиндром");
    }
}