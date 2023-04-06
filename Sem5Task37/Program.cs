/* Задача №37
Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве. */

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

int[] ConvertArr(int[] array)
{
    int len = (array.Length % 2 == 0) ? array.Length / 2 : array.Length / 2 + 1;
    int[] outArr = new int[len];

    for (int i = 0; i < len; i++)
    {
        outArr[i] = array[i] * array[array.Length - 1 - i];
    }
    return outArr;
}

int[] testArr = Gen1DArr(12, 20, 1);
Print1DArr(testArr);
Console.WriteLine(ConvertArr(testArr));