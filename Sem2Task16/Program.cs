int firstNumber = int.Parse(Console.ReadLine() ?? "0");
int secondNumber = int.Parse(Console.ReadLine() ?? "0");

void SqrtTest(int a, int b)
{
    if (a == b * b)
    {
        Console.WriteLine(a + " квадрат " + b);
    }
    else
    {
        Console.WriteLine(a + " не квадрат " + b);
    }
}
if (firstNumber > secondNumber)
{
    SqrtTest(firstNumber, secondNumber);
}
else
{
    SqrtTest(secondNumber, firstNumber);
}






