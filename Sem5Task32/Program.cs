/* Задача №32
Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот. */

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

void InversArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * (-1);
    }
}

int[] testArr = Gen1DArr(12,9,-9);
Print1DArr(testArr);
InversArr(testArr);
Print1DArr(testArr);