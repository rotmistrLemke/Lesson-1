
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

//метод получения суммы элементов, стоящих на нечётных позициях
int SumUnevenElement(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

// методл сортировки подсчетом
int[] CountingSort(int[] array)
{
    int min = array[0];
    int max = array[0];
    foreach (int element in array)
    {
        if (element > max)
        {
            max = element;
        }
        else if (element < min)
        {
            min = element;
        }
    }

    int correctionFactor = min != 0 ? -min : 0;
    max += correctionFactor;

    int[] count = new int[max + 1];
    for (int i = 0; i < array.Length; i++)
    {
        count[array[i] + correctionFactor]++;
    }

    int index = 0;
    for (int i = 0; i < count.Length; i++)
    {
        for (int j = 0; j < count[i]; j++)
        {
            array[index] = i - correctionFactor;
            index++;
        }
    }

    return array;
}

//метод подсчета пар
void SearchPair(int[] arr)
{
    //соритруем
    CountingSort(arr);
    //сравниваем соседние
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i - 1] == arr[i])
        {
            Console.WriteLine("Найдена пара: " + arr[i - 1] + " и " + arr[i]);
        }
    }
}
// генерируем массив
int[] arr = Gen1DArr(10, 1, 9);
//считаем сумму элементов, стоящих на нечётных позициях
Console.WriteLine("сумма элементов, стоящих на нечётных позициях равна:" + SumUnevenElement(arr));
//вывод для проверки
Print1DArr(arr);
SearchPair(arr);



