// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int[,] MatrixRequest()
{
    int minValue = 0;
    int maxValue = 10;
    int inputRows = ValueRequest("number of rows");
    int inputColumns = ValueRequest("number of columns");
    int[,] resultMatrix = GetMatrix(inputRows, inputColumns, minValue, maxValue);
    return resultMatrix;
}

int[,] RequestMatrixWithRectangularCheck()
{
    Console.WriteLine("Enter parameters for RECTENGULAR matrix");
    int[,] matrix = MatrixRequest();
    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
        Console.WriteLine("Number of rows equals number of columns, its SQUARE matrix. Try again.");
        matrix = RequestMatrixWithRectangularCheck();
    }
    return matrix;
}

int FindRowIndexWithTheLowestSum(int[,] matrix)
{
    int counter = 0;
    int lowestSum = int.MaxValue;
    int rowIndexWithTheLowestSum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        counter = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            counter += matrix[i, j];
        }

        if (lowestSum > counter)
        {
            lowestSum = counter;
            rowIndexWithTheLowestSum = i;
        }
    }
    return rowIndexWithTheLowestSum;
}

int[,] resultMatrix = RequestMatrixWithRectangularCheck();
PrintMatrix(resultMatrix);
Console.WriteLine($"Index of row with the lowest sum is [{FindRowIndexWithTheLowestSum(resultMatrix)}]");