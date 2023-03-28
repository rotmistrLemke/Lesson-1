System.Random numSintezator = new System.Random();

char[] digits = numSintezator.Next(100, 1000).ToString().ToCharArray();
Console.WriteLine(digits);
char[] res = { digits[0], digits[2] };
Console.WriteLine(res);

