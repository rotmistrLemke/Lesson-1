/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */




int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод, генерирующий массив
int[,,] Gen3DArray(int countRow, int countColumn, int countDeep, int minValue, int maxValue)
{
    Random rand = new Random((int)DateTime.Now.Ticks); // генерация неопвторяющихся чисел
    int[,,] arr = new int[countRow, countColumn, countDeep];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            for (int k = 0; k < countDeep; k++)
            {
                arr[i, j, k] = rand.Next(minValue,maxValue+1);
            }
        }
    }
    return arr;
}

void Print3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write(arr[i, j, k] + "(" + i + "," + j + "," + k + ")");
            }
            Console.WriteLine();
        }
    }
}

int a = ReadData("Введите количество строк: ");
int b = ReadData("Введите количество столбцов: ");
int c = ReadData("Введите глубину массива: ");
int[,,] array3D = Gen3DArray(a,b,c,10,99);
Print3DArray(array3D);








