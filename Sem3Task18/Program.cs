//Чтение данных консоли
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
//метод ответа
void PrintAnswer(int quoter)
{
    if (quoter == 1) Console.WriteLine("(x от 1 до n, y 1 до n)");
    if (quoter == 2) Console.WriteLine("(x от 1 до n, y -1 до -n)");
    if (quoter == 3) Console.WriteLine("(x от -1 до -n, y -1 до -n)");
    if (quoter == 4) Console.WriteLine("(x от -1 до -n, y 1 до n)");
    if (quoter < 1 || quoter > 4) Console.WriteLine("такой четверти нет");
}

//вызовы методов

try
{
    int quoter = ReadData("Введите четверть: ");
    PrintAnswer(quoter);
}
catch
{
    Console.WriteLine("такой четверти нет");
}