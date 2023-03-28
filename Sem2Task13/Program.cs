int number = int.Parse(Console.ReadLine() ?? "0");


bool res = (number % 7 == 0 && number % 23 == 0);
if (res)
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
{
    Console.WriteLine("Число некратно 7 и 23");
}



