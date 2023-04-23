/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
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



// Метод, генерирующий массив
int[,] Gen2DArray(int countRow, int countColumn, int minValue, int maxValue)
{
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return arr;
}

void Print2DArray(int[,] arr)
{
    int [] sortedString = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           sortedString[j] = arr[i,j];
        }
        
        sortedString = CountingSort(sortedString);
       
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           arr[i,j] = sortedString[j];
           Console.Write(arr[i, j] + " ");
        }
    Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк: ");
int col = ReadData("Введите количество столбцов: ");
int[,] arr2D = Gen2DArray(row, col, 1, 10);
Print2DArray(arr2D);
