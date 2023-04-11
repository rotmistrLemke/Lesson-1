/* Задача №33
Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. */

int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}


int[] Gen1DArr(int len, int top, int but)
{
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(but, top + 1);
    }
    return res;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

void SerchElementInArr(int element,int[] arr)
{
    
    int pos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == element)
        {
           pos = i-1;
            Console.WriteLine("элемент  найден");
        }

    }
}




int[] testArr = Gen1DArr(14,13,-9);
Print1DArr(testArr);
int numForSearch = ReadData("Введите элемент для поиска: ");
SerchElementInArr(numForSearch,testArr);
