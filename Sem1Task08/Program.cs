//вводим число
Console.WriteLine("Введите число");
int inlineNimber = int.Parse(Console.ReadLine() ?? "0");
//Объявляем счетчик
int counter = 1;

//Выводим числа
Console.Write($"Четные числа от 1 до {inlineNimber} это: ");

while (counter <= inlineNimber)
{
    if (counter % 2 == 0)
    {
        Console.Write(counter + " ");
        counter++;
    }
    else
    {
        counter++;
    }
}
