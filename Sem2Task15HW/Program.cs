/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
* Сделать вариант с использованием конструкции Dictionary
*/

//Чтение данных консоли
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Функция проверят, чтобы число день недели существовал
bool CheckNumber(int numDay)
{
    if (numDay < 1 || numDay > 7)
    {
        Console.WriteLine("это не день недели");
        return false;
    }
    return true;
}
// Объяление словаря
Dictionary<int, string> DaysWeek = new Dictionary<int, string>();
// Добавляем значения в словарь
DaysWeek.Add(1, "Понедельник");
DaysWeek.Add(2, "Вторник");
DaysWeek.Add(3, "Среда");
DaysWeek.Add(4, "Четверг");
DaysWeek.Add(5, "Пятница");
DaysWeek.Add(6, "Суббота");
DaysWeek.Add(7, "Воскресенье");

int day = ReadData("Введите число: ");
if (CheckNumber(day))
{
    bool blow = (day > 5) ? true : false;
    if (blow)
{
    Console.Write(DaysWeek[day]);
    Console.WriteLine(" - Выходной");
}
    else 
{
    Console.Write(DaysWeek[day]);
    Console.WriteLine(" - Рабочий день");
}
}
