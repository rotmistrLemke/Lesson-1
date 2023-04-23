/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
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
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Multiplication(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0)) throw new Exception("Матрицы нельзя перемножить"); //проверка на одинаковый порядок и вывод ошибки если порядок не совпадает
    int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return resultMatrix;
}

int a = ReadData("Введите порядок первой матрицы: ");
int b = ReadData("Введите порядок второй матрицы: ");
int[,] matrixA = Gen2DArray(a, a, 1, 10);
int[,] matrixB = Gen2DArray(b, b, 1, 10);
Print2DArray(matrixA);
Console.WriteLine();
Print2DArray(matrixB);
Console.WriteLine();
Console.WriteLine("Ответ:");
Print2DArray(Multiplication(matrixA, matrixB));
