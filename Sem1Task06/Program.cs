//Вводим число, для проверки на четность
Console.WriteLine("Введите число, для проверки на четность");
int inlineNumber = int.Parse(Console.ReadLine() ?? "0");

//Проверяем на четность
if (inlineNumber % 2 == 0)
{
    Console.WriteLine($"Число {inlineNumber} четное");
}
else
{
    Console.WriteLine($"Число {inlineNumber} нечетное");
}
