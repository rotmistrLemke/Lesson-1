//Чтение данных консоли
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

void PrintQouterTest(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("Точка в первой четверти");
    if (x > 0 && y < 0) Console.WriteLine("Точка в второй четверти");
    if (x < 0 && y < 0) Console.WriteLine("Точка в третьей четверти");
    if (x < 0 && y > 0) Console.WriteLine("Точка в четвертой четверти");
}

int coordX = ReadData("Введите координату Х: ");
int coordY = ReadData("Введите координату Y: ");
PrintQouterTest(coordX, coordY);