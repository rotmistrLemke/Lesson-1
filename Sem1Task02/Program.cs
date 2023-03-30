//Вводим числа для проверки
int firstNum = int.Parse(Console.ReadLine() ?? "0");
int secondNum = int.Parse(Console.ReadLine() ?? "0");

//Проверям на максимальное
string res = (firstNum > secondNum) ? $"{firstNum} больше чем {secondNum}" : $"{secondNum} больше чем {firstNum}";
Console.WriteLine(res);
