﻿//Считываем данные с консоли
string? inLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (inLine != null)
{
    //Парсим введенное число
    int inNumber = int.Parse(inLine);

    //Находим квадрат числа
    int outNumber = inNumber * inNumber;
    int outStrtPow = (int)Math.Pow(inNumber,2);

    //int outNumberTest = inLine.ToCharArray()[0]*inLine.ToCharArray()[0];

    // Выводим данные в консоль 
    Console.WriteLine(outNumber);
    // Выводим данные в консоль 
    Console.WriteLine(outStrtPow);
}
