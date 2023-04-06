/* 
Задача №31
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
 */
int globPosSum = 0;
int globNegSum = 0;

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

void NegPosSumV1(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0)
        {
            globPosSum+=arr[i];
        }
        else
        {
             globNegSum+=arr[i];
        }
    }
}

int[] NegPosSumV2(int[] arr)
{
    int positivSum = 0;
    int negativeSum = 0;
    int[] outArr = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0)
        {
            positivSum+=arr[i];
        }
        else
        {
             negativeSum+=arr[i];
        }
    }
    outArr[0] = positivSum;
    outArr[1] = negativeSum;
    return outArr;
}

(int positive, int negative) NegPosSumV3(int[] arr)
{
    int positivSum = 0;
    int negativeSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0)
        {
            positivSum+=arr[i];
        }
        else
        {
            negativeSum+=arr[i];
        }
    }
    return (positivSum,negativeSum);
}

int[] testArr = Gen1DArr(12,9,-9);
Print1DArr(testArr);
NegPosSumV1(testArr);
int[] res = NegPosSumV2(testArr);

(int positive,int negative) sum = NegPosSumV3(testArr);

Console.WriteLine("Сумма положительных чисел в массиве " + globPosSum);
Console.WriteLine("Сумма отрицательных чисел в массиве " + globNegSum);

Console.WriteLine("Сумма положительных чисел в массиве " + res[0]);
Console.WriteLine("Сумма отрицательных чисел в массиве " + res[1]);

Console.WriteLine("Сумма положительных чисел в массиве " + sum.positive);
Console.WriteLine("Сумма отрицательных чисел в массиве " + sum.negative);