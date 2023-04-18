﻿// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

//  метод считывания данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));
    return res;
}

string DecToBin(int num)
{
    string res = String.Empty;
    while (num > 0)
    {
        res += num % 2;
        num = num / 2;
        Console.WriteLine(res + " "+num);
    }
    return res;
}

string res = "";
int a = ReadData("Введите А");
res = DecToBin(a);
Console.WriteLine(res);

Console.WriteLine(Convert.ToString(a,2));
Console.WriteLine(Convert.ToString(a,8));
Console.WriteLine(Convert.ToString(a,16));