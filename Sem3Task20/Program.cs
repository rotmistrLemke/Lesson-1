//Чтение данных консоли
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

double CalcLen2D(int x1, int y1, int x2, int y2)
{
    double result = Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2));
    return result;
}


int coordX1 = ReadData("Введите координату Х: ");
int coordY1 = ReadData("Введите координату Y: ");
int coordX2 = ReadData("Введите координату Х: ");
int coordY2 = ReadData("Введите координату Y: ");

Console.WriteLine(CalcLen2D(coordX1, coordY1, coordX2, coordY2));