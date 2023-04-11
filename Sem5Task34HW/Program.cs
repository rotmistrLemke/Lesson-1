
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

int GetEvenCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

//метод сортировки пузырьком
int[] BubbleSort(int[] mas)
{
    int temp;
    for (int i = 0; i < mas.Length; i++)
    {
        for (int j = i + 1; j < mas.Length; j++)
        {
            if (mas[i] > mas[j])
            {
                temp = mas[i];
                mas[i] = mas[j];
                mas[j] = temp;
            }
        }
    }
    return mas;
}

// методл сортировки подсчетом
int[] CountingSort(int[] array)
{
    //поиск минимального и максимального значений
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

    //поправка
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

// генерируем массив
int[] arr = Gen1DArr(100000, 100, 999);

//считаем количество четных чисел
Console.WriteLine("Количество четных чисел равно: " + GetEvenCount(arr));
// засекаем время старта
var timeStart = DateTime.Now;
// сортируем подсчетом
CountingSort(arr);
// засекаем время окончания
var timeEnd = DateTime.Now;
//получаем время выполнения
var time = timeEnd - timeStart;

Console.WriteLine("Время сортировки методом подсчета: " + time);

timeStart = DateTime.Now;
// сорируем пузырьком
BubbleSort(arr);
timeEnd = DateTime.Now;
time = timeEnd - timeStart;
Console.WriteLine("Время сортировки методом пузырька: " + time);

