/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
* Заполнить числами Фиббоначи и выделить цветом найденную цифру */


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод, генерирующий массив
int[,] Gen2DArray(int countRow, int countColumn)
{
    //генерируем массив с последователоьностью Фибоначчи
    int[] fib = new int[10];
    fib[0] = 0;
    fib[1] = 1;
    for (int i = 2; i < fib.Length; i++)
    {
        fib[i] = fib[i - 1] + fib[i - 2];
    }
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = fib[new Random().Next(1, fib.Length)]; //заполняем выходной массив числами из массива Фибоначчи путем перебора случайных индексов из массива фибоначчи
        }
    }
    return arr;
}

void Print2DArray(int[,] arr, int column, int row)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    if (row<=arr.GetLength(0) && column<=arr.GetLength(1))
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (i == (row - 1) && j == (column - 1)) // Проверяем есть ли такая строка и столбоци раскрашиваем
                {
                    Console.ForegroundColor = col[new Random().Next(0, 16)];
                    Console.Write(arr[i, j] + " ");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(arr[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
    else 
    {
        Console.WriteLine("Такой позиции не существует");
    }
    
}


int row = ReadData("Введите номер строки: ");
int column = ReadData("Введите номер столбца: ");
int[,] arr2D = Gen2DArray(5, 5);
Print2DArray(arr2D,column,row);



