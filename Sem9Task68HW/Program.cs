/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
*/


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}




///Метод вычисления функции Аккермана:
int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
return AckermannFunction(numberM, numberN);
}

int numberM = ReadData("Введите начальное число M: ");
int numberN = ReadData("Введите начальное число N: ");
Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");