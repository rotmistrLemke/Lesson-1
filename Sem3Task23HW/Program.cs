/* 
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
* Вывести таблицу с границами и значениями друг над другом
 */
/* 
Console.Write('╔');
for (int index = 1; index != 5; index++)
   Console.Write("═════");
Console.Write('╗');

*/

//Чтение данных консоли
int ReadData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

int n = ReadData("Введите число");
Console.Clear();


Console.Write('╔');
for (int index = 1; index <= n; index++)
{
    Console.Write("════════");
}
Console.Write('╗');

Console.WriteLine();

Console.Write("║ ");
for (int i = 1; i <= n; i++)
{
    Console.Write("{0}\t",i);
}
Console.Write(" ║");
Console.WriteLine();

Console.Write('╚');
for (int index = 1; index <= n; index++)
{
    Console.Write("════════");
}
Console.Write('╝');

Console.WriteLine();

Console.Write('╔');
for (int index = 1; index <= n; index++)
{
    Console.Write("════════");
}
Console.Write('╗');

Console.WriteLine();


Console.Write("║ ");
for (int i = 1; i <= n; i++)
{
    Console.Write("{0}\t", Math.Pow(i,3));
}
Console.Write(" ║");

Console.WriteLine();

Console.Write('╚');
for (int index = 1; index <= n; index++)
{
    Console.Write("════════");
}
Console.Write('╝');
