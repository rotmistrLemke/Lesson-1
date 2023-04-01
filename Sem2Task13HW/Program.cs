/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
* Сделать вариант для числа длиной до 10 цифр не используя char или string
*/

//Чтение данных консоли
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
// Функция проверят, чтобы число имело больше 3 цифр
bool CheckNumber(int num)
{
    if (num < 100)
    {
        Console.WriteLine("третьей цифры нет");
        return false;
    }
    return true;
}

// функция выводит 3 цифру числа
int ShowNumber(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}

// вызов чтения данных
int num = ReadData("Введите число: ");

//проверяем число 
if (CheckNumber(num))
{
    Console.WriteLine(ShowNumber(num));
}