

System.Random numSintezator = new System.Random();
int rndNum = numSintezator.Next(10, 100);
Console.WriteLine(rndNum);
int firstNum = (int)(rndNum / 10);
int secondNum = (int)(rndNum % 10);

if (firstNum > secondNum)
{
    Console.WriteLine(firstNum);
}
else
{
    Console.WriteLine(secondNum);
}

//Вариант 2

char[] digits = numSintezator.Next(10, 100).ToString().ToCharArray();
Console.WriteLine(digits);
firstNum = (digits[0]) - 48;
secondNum = (digits[1]) - 48;
int res = (firstNum > secondNum)? firstNum: secondNum;
Console.WriteLine(res);