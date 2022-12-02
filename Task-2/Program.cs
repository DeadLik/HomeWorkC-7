// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void CheckingValues(int[,] matrix, int line, int column)
{
    if (line > matrix.GetLength(0) || column > matrix.GetLength(1)) Console.WriteLine("Такого элемента нет");
    else Console.WriteLine($"Значение элемента {line} строки и {column} столбца = {matrix[line - 1, column - 1]}");
}

int[,] numbers = CreateMatrixRndInt(5, 5, 1, 100);

Console.Write("Введите номер строки: ");
int lineNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int columnNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
CheckingValues(numbers, lineNumber, columnNumber);
Console.WriteLine();
PrintMatrix(numbers);


