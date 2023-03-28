//Вводим числа для проверки
Console.WriteLine("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число: ");
int secondNum = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите третье число: ");
int thirdNum = int.Parse(Console.ReadLine() ?? "0");


//Проверям на максимальное
if (firstNum > secondNum && firstNum > thirdNum)
{
    Console.WriteLine($"{firstNum} больше чем {secondNum} и {thirdNum}");
}
else
{
    if (secondNum > firstNum && secondNum > thirdNum)
    {
        Console.WriteLine($"{secondNum} больше чем {firstNum} и {thirdNum}");
    }
    else
    {
        Console.WriteLine($"{thirdNum} больше чем {firstNum} и {secondNum}");
    }
}