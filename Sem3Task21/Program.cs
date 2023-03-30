//Чтение данных консоли
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

double CalcLen2D(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((y1 - y2), 2));
    return result;
}


int coordX1 = ReadData("Введите координату Х1: ");
int coordX2 = ReadData("Введите координату Х2: ");
int coordY1 = ReadData("Введите координату Y1: ");
int coordY2 = ReadData("Введите координату Y2: ");
int coordZ1 = ReadData("Введите координату Z1: ");
int coordZ2 = ReadData("Введите координату Z2: ");

Console.WriteLine(CalcLen2D(coordX1, coordX2, coordY1, coordY2, coordZ1, coordZ2));