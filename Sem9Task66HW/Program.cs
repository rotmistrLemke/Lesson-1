/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}


int  SumRec(int m, int n)
{
    if (m < n)
    {
       return m + SumRec(m + 1, n);
    }
    else
    {
        return m;
    }
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");


Console.WriteLine(SumRec((m > n) ? n : m, (m > n) ? m : n));