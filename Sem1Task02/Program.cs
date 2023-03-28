int firstNum = int.Parse(Console.ReadLine() ?? "0");
int secondNum = int.Parse(Console.ReadLine() ?? "0");

string res = (firstNum>secondNum)?$"{firstNum} больше чем {secondNum}":$"{secondNum} больше чем {firstNum}";
Console.WriteLine(res);