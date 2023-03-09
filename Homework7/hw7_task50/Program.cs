// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//1(строчка) 7 (столбец) -> такого числа в массиве нет


int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("Your matrix:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int ValueRequest(string requestDescription)
{
    Console.WriteLine($"Enter {requestDescription} :");
    int value = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    return value;
}

int GetValueFromMatrix(int[,] matrix, int rowNumber, int columnNumber)
{
    int value = matrix[rowNumber-1, columnNumber-1];  
    return value;
}

int min = 0;
int max = 100;
int inputRows = ValueRequest("number of rows");
int inputColumns = ValueRequest("number of columns");

int[,] resultMatrix = GetMatrix(inputRows, inputColumns, min, max);
PrintMatrix(resultMatrix);

Console.WriteLine("Lets search the value in your matrix");
int inputRowNumber = ValueRequest($"row number from 1 to {inputRows}");
int inputColumnNumber = ValueRequest($"column number from 1 to {inputColumns}");
int searchResult = GetValueFromMatrix(resultMatrix, inputRowNumber, inputColumnNumber);

Console.WriteLine($"Value in row[{inputRowNumber}] column[{inputColumnNumber}] is {searchResult}");