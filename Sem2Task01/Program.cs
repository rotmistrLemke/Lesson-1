

System.Random numSintezator = new System.Random();
int rndNum = numSintezator.Next(10, 100);
Console.WriteLine(rndNum);
short firstNum = (short)(rndNum / 10);
short secondNum = (short)(rndNum % 10);

if (firstNum > secondNum)
{
    Console.WriteLine(firstNum);
}
else
{
    Console.WriteLine(firstNum);
}

//Вариант 2

char[] digits = numSintezator.Next(10, 100).ToString().ToCharArray();
Console.WriteLine(digits);
firstNum = (int)(digits[0]) - 48;
secondNum = (int)(digits[1]) - 48;