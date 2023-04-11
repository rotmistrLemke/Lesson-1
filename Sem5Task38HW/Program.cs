//метод генерации массива
int[] Gen1DArr(int len, int but, int top)
{
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(but, top + 1);
    }
    return res;
}
// метод вывода массива
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
// сортировка вставкой
int[] InsertionSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int k = arr[i];
        int j = i - 1;

        while (j >= 0 && arr[j] > k)
        {
            arr[j + 1] = arr[j];
            arr[j] = k;
            j--;
        }
    }
    return arr;
}

// генерируем массив
int[] arr = Gen1DArr(10, 1, 9);
Print1DArr(arr);
// Выводим ответ
Console.WriteLine("Разница между максмальным (" + InsertionSort(arr)[arr.Length - 1] +
") и минимальным (" + InsertionSort(arr)[0] + ") значениями массива равна: " + (InsertionSort(arr)[arr.Length - 1] - InsertionSort(arr)[0]));