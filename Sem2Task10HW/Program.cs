/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

//Чтение данных консоли
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Функция проверят, чтобы число было трехзначным
bool CheckNumber(int num)
{
    if (num < 100 || num > 1000)
    {
        Console.WriteLine("число не является трехзначным");
        return false;
    }
    return true;
}

// функция выводит 3 цифру числа
char[] ShowNumber(int num)
{
    char[] digits = num.ToString().ToCharArray();
    char[] res = {digits[1]};
    return res;
}

// вызов чтения данных
int num = ReadData("Введите число: ");

//проверяем число 
if (CheckNumber(num))
{
    //показываем число 
    Console.WriteLine(ShowNumber(num));
}